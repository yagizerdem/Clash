use crate::parser::{ast::{self, AstNode}, clash_parser::clash_base_parser::{check_type, dispatcher, extract_syntax_info, get_optional_child_by_field_name, get_optional_children_by_field_name, get_program_by_offset, get_required_child_by_field_name, get_required_named_children, ts_node_to_ast_node, ts_nodes_to_ast_nodes}};

pub fn parse_binary_expression(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    check_type(node, "binary_expression")?;
    let ts_left_node : Option<tree_sitter::Node> = get_optional_child_by_field_name(node, "left")?;
    let ts_operator_node : tree_sitter::Node = get_required_child_by_field_name(node, "operator")?;
    let ts_right_node : Option<Vec<tree_sitter::Node>> = get_optional_children_by_field_name(node, "right")?;

    let syntax_info = extract_syntax_info(program, node)?;
    let operator : String = get_program_by_offset(program, ts_operator_node)?;

    let ast_left_node: Option<Box<AstNode>> = match ts_left_node {
        Some(node) => Some(Box::new(ts_node_to_ast_node(program, node)?)),
        None => None,
    };
    let ast_right_nodes: Option<Vec<AstNode>> = match ts_right_node {
        Some(nodes) => Some(
            ts_nodes_to_ast_nodes(program, nodes)?
        ),
        None => None,
    };

    return Ok(AstNode::BinaryExpr(ast::BinaryExpr{
        syntax_info,
        left: ast_left_node,
        operator,
        right: ast_right_nodes
    }));

}

pub fn concationation_parser(program: &str, node: tree_sitter::Node) -> Result<AstNode, String>  {
    check_type(node, "concatenation")?;
    let syntax_info = extract_syntax_info(program, node)?;
    let ts_parts: Vec<tree_sitter::Node> = get_required_named_children(node)?;

    // parse named children to ast-ndoe
    let ast_nodes : Vec<AstNode> = ts_nodes_to_ast_nodes(program, ts_parts)?;

    return Ok(AstNode::Concatenation(
        ast::Concatenation {
            parts: ast_nodes,
            syntax_info,
        }
    ))
}

pub fn parenthesized_expression_parser(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    check_type(node, "parenthesized_expression")?;
    let syntax_info = extract_syntax_info(program, node)?;
    let ts_expression_nodes: Vec<tree_sitter::Node> = get_required_named_children(node)?;

    let ast_expression_nodes: Vec<AstNode> = ts_nodes_to_ast_nodes(program, ts_expression_nodes)?;

    return Ok(AstNode::ParenthesizedExpression(
        ast::ParenthesizedExpression {
            expression: ast_expression_nodes,
            syntax_info,
        }
    ));
}

