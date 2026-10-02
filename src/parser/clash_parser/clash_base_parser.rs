use tree_sitter;
use crate::parser::{ast::{AstNode, SyntaxInfo}, clash_parser::expr_parser::{concationation_parser, parenthesized_expression_parser, parse_binary_expression}};


pub fn get_program_by_offset(
    program: &str,
    node: tree_sitter::Node,
) -> Result<String, String> {
    let buffer = program.as_bytes();

    let slice = buffer
        .get(node.start_byte()..node.end_byte())
        .ok_or_else(|| {
            format!(
                "Invalid byte range: {}..{}",
                node.start_byte(),
                node.end_byte()
            )
        })?;

    Ok(String::from_utf8_lossy(slice).to_string())
}

pub fn extract_syntax_info(
    program: &str,
    node: tree_sitter::Node,
) -> Result<SyntaxInfo, String> {
    let raw = get_program_by_offset(program, node)?;

    Ok(SyntaxInfo {
        end_byte: node.end_byte(),
        start_byte: node.start_byte(),
        raw,
    })
}

pub fn is_missing_node(node: tree_sitter::Node) -> bool {
    node.is_missing()
}

pub fn is_error_node(node: tree_sitter::Node) -> bool {
    node.is_error()
}

pub fn get_required_children_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<Vec<tree_sitter::Node<'a>>, String> {
    let mut children = Vec::new();
    for i in 0..node.child_count() {
        if let Some(name) = node.field_name_for_child(i as u32) {
            if name == field_name {
                children.push(node.child(i).ok_or_else(|| {
                    format!("Failed to get child at index: {}", i)
                })?);
            }
        }
    }
    return Ok(children);
}

pub fn get_optional_children_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<Option<Vec<tree_sitter::Node<'a>>>, String> {
    let mut children = Vec::new();
    for i in 0..node.child_count() {
        if let Some(name) = node.field_name_for_child(i as u32) {
            if name == field_name {
                if let Some(child) = node.child(i) {
                    children.push(child);
                }
            }
        }
    }
    return Ok(Some(children));
}

pub fn get_required_child_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<tree_sitter::Node<'a>, String> {
    node.child_by_field_name(field_name).ok_or_else(|| {
        format!("Missing child node with field name: {}", field_name)
    })
}

pub fn get_optional_child_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<Option<tree_sitter::Node<'a>>, String> {
    Ok(node.child_by_field_name(field_name))
}

pub fn get_required_named_children<'a>(node: tree_sitter::Node<'a>) -> Result<Vec<tree_sitter::Node<'a>>, String> {
    let mut children: Vec<tree_sitter::Node> = Vec::new();
    for i in 0..(node.named_child_count()) {
        let ts_node = node.named_child(i).ok_or_else(|| {
            "Named child is missing"
        })?;
        children.push(ts_node);
    };

    return Ok(children);
}

pub fn get_optional_named_children<'a>(node: tree_sitter::Node<'a>) -> Result<Option<Vec<tree_sitter::Node<'a>>>, String> {
    let mut children: Vec<tree_sitter::Node> = Vec::new();
    for i in 0..(node.named_child_count()) {
        if let Some(ts_node) = node.named_child(i) {
            children.push(ts_node);
        }
    }
    Ok(Some(children))
}

pub fn dispatcher(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    match node.kind() {
        // expr
        "binary_expression" => {
            parse_binary_expression(program, node)
        },
        "concatenation" => {
            concationation_parser(program, node)
        },
        "parenthesized_expression" => {
            parenthesized_expression_parser(program, node)
        },
        _ => {
            Err("Unknown node kind, only named nodes are supported".to_string())
        }
    }
}

pub fn parse_child(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    if is_missing_node(node) {
        return Err("Missing node".to_string());
    }

   if !node.is_named() {
       return Err(format!("Unnamed node {{kind: {}}}", node.kind()));
   }

    dispatcher(program, node)
}

pub fn check_type(node: tree_sitter::Node, expected_kind: &str) -> Result<(), String> {
    if node.kind() != expected_kind {
        return Err(format!("Unexpected node kind, expected: {}, found: {}", expected_kind, node.kind()));
    }
    Ok(())
}

pub fn ts_node_to_ast_node(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    parse_child(program, node)
}

pub fn ts_nodes_to_ast_nodes(program: &str, nodes: Vec<tree_sitter::Node>) -> Result<Vec<AstNode>, String> {
    let mut ast_nodes = Vec::new();
    for node in nodes {
        ast_nodes.push(ts_node_to_ast_node(program, node)?);
    }
    Ok(ast_nodes)
}

