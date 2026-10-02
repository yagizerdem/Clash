use tree_sitter;
use crate::parser::{ast::{AstNode, SyntaxInfo}, clash_parser::expr_parser::parse_binary_expression};


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

pub fn get_optional_children_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<Vec<tree_sitter::Node<'a>>, String> {
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
    return Ok(children);
}

pub fn get_required_child_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<tree_sitter::Node<'a>, String> {
    node.child_by_field_name(field_name).ok_or_else(|| {
        format!("Missing child node with field name: {}", field_name)
    })
}

pub fn get_optional_child_by_field_name<'a>(node: tree_sitter::Node<'a>, field_name: &str) -> Result<Option<tree_sitter::Node<'a>>, String> {
    Ok(node.child_by_field_name(field_name))
}

pub fn dispatcher(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    match node.kind() {
        // expr
        "" => {
            parse_binary_expression(program, node)
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
