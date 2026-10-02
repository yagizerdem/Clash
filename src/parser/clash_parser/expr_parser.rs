use crate::parser::{ast::{self, AstNode}, clash_parser::clash_base_parser::{check_type, dispatcher, extract_syntax_info, get_program_by_offset, get_required_child_by_field_name, get_required_children_by_field_name}};

pub fn parse_binary_expression(program: &str, node: tree_sitter::Node) -> Result<AstNode, String> {
    check_type(node, "binary_expression")?;
    let ts_left_node : tree_sitter::Node = get_required_child_by_field_name(node, "left")?;
    let ts_operator_node : tree_sitter::Node = get_required_child_by_field_name(node, "operator")?;
    let ts_right_node : Vec<tree_sitter::Node> = get_required_children_by_field_name(node, "right")?;

    let syntax_info = extract_syntax_info(program, node)?;
    let operator : String = get_program_by_offset(program, ts_operator_node)?;

    let ast_left_node = dispatcher(program, ts_left_node)?;
    let ast_right_nodes: Vec<AstNode> = ts_right_node
    .into_iter()
    .map(|n| dispatcher(program, n))
    .collect::<Result<_, _>>()?; 

    return Ok(AstNode::BinaryExpr((ast::BinaryExpr{
        syntax_info,
        left: Box::new(ast_left_node),
        operator,
        right: ast_right_nodes
    })));

}

    // public AstNode parse(TSNode tsNode) {
    //     this.checkType(tsNode, "binary_expression");
    //     SyntaxInfo syntaxInfo = this.extractSyntaxInfo();
    //     TSNode tsLeftNode = tsNode.getChildByFieldName("left");
    //     TSNode tsOperatorNode = tsNode.getChildByFieldName("operator");
    //     String operator = this.getProgramByOffsets(tsOperatorNode);
    //     List<TSNode> tsRightNodes = this.getChildrenByFieldName(tsNode, "right");

    //     AstNode cLeftNode = this.isMissing(tsLeftNode)
    //             ? null
    //             : this.parseChild(tsLeftNode);
    //     List<AstNode> cRightNodes = new ArrayList<>();
    //     tsRightNodes.forEach(tsn -> {
    //         cRightNodes.add(this.parseChild(tsn));
    //     });

    //     return new BinaryExpressionNode(syntaxInfo, cLeftNode, operator, cRightNodes);
    // }