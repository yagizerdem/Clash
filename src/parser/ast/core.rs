use crate::parser::ast::{self, AstNode::BinaryExpr};


pub struct Program {
    pub statements: Vec<AstNode>,
}

impl std::fmt::Debug for Program {
    fn fmt(&self, f: &mut std::fmt::Formatter<'_>) -> std::fmt::Result {
        write!(f, "Ast Nodes:\n")?;
        for i in 0..self.statements.len() {
            write!(f, "{:?} \n", self.statements[i])?;
        }
        Ok(())
    }
}


pub enum AstNode {
    // expr
    BinaryExpr(ast::BinaryExpr),
    Concatenation(ast::Concatenation),
    ParenthesizedExpression(ast::ParenthesizedExpression),
    PostfixExpression(ast::PostfixExpression),
    TernaryExpression(ast::TernaryExpression),
    UnaryExpression(ast::UnaryExpression),
    Word(ast::Word),

    //primary_expr
    AnsiCString(ast::AnsiCString),
    ArithmeticExpansion(ast::ArithmeticExpansion),
    BraceExpression(ast::BraceExpression),
    CommandSubstitution(ast::CommandSubstitution),
    Expansion(ast::Expansion),
    Number(ast::Number),
    ProcessSubstitution(ast::ProcessSubstitution),
    RawString(ast::RawString),
    SimpleExpansion(ast::SimpleExpansion),
    StringNode(ast::StringNode),
    TranslatedString(ast::TranslatedString),

    // stmt
    CaseStatement(ast::CaseStatement),
    Command(ast::Command),
    CompoundStatement(ast::CompoundStatement),
    CStyleForStatement(ast::CStyleForStatement),
    DeclarationCommand(ast::DeclarationCommand),
    ForStatement(ast::ForStatement),
    FunctionDefinition(ast::FunctionDefinition),
    IfStatement(ast::IfStatement),
    List(ast::List),
    NegatedCommand(ast::NegatedCommand),
    Pipeline(ast::Pipeline),
    RedirectedStatement(ast::RedirectedStatement),
    Subshell(ast::Subshell),
    TestCommand(ast::TestCommand),
    UnsetCommand(ast::UnsetCommand),
    VariableAssignment(ast::VariableAssignment),
    VariableAssignments(ast::VariableAssignments),
    WhileStatement(ast::WhileStatement),

    // other
    Array(ast::Array),
    CaseItem(ast::CaseItem),
    CommandName(ast::CommandName),
    Comment(ast::Comment),
    DoGroup(ast::DoGroup),
    ElifClause(ast::ElifClause),
    ElseClause(ast::ElseClause),
    ExtglobPattern(ast::ExtglobPattern),
    FileDescriptor(ast::FileDescriptor),
    FileRedirect(ast::FileRedirect),
    HeredocBody(ast::HeredocBody),
    HeredocContent(ast::HeredocContent),
    HeredocEnd(ast::HeredocEnd),
    HeredocRedirect(ast::HeredocRedirect),
    HeredocStart(ast::HeredocStart),
    HerestringRedirect(ast::HerestringRedirect),
    Regex(ast::Regex),
    SpecialVariableName(ast::SpecialVariableName),
    StringContent(ast::StringContent),
    Subscript(ast::Subscript),
    TestOperator(ast::TestOperator),
    VariableName(ast::VariableName),
}


impl std::fmt::Debug for AstNode {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        match self {
            // expr
            AstNode::BinaryExpr(node) => write!(f, "{:?}", node),
            AstNode::Concatenation(node) => write!(f, "{:?}", node),
            AstNode::ParenthesizedExpression(node) => write!(f, "{:?}", node),
            AstNode::PostfixExpression(node) => write!(f, "{:?}", node),
            AstNode::TernaryExpression(node) => write!(f, "{:?}", node),
            AstNode::UnaryExpression(node) => write!(f, "{:?}", node),
            AstNode::Word(node) => write!(f, "{:?}", node),

            // primary expr
            AstNode::AnsiCString(node) => write!(f, "{:?}", node),
            AstNode::ArithmeticExpansion(node) => write!(f, "{:?}", node),
            AstNode::BraceExpression(node) => write!(f, "{:?}", node),
            AstNode::CommandSubstitution(node) => write!(f, "{:?}", node),
            AstNode::Expansion(node) => write!(f, "{:?}", node),
            AstNode::Number(node) => write!(f, "{:?}", node),
            AstNode::ProcessSubstitution(node) => write!(f, "{:?}", node),
            AstNode::RawString(node) => write!(f, "{:?}", node),
            AstNode::SimpleExpansion(node) => write!(f, "{:?}", node),
            AstNode::StringNode(node) => write!(f, "{:?}", node),
            AstNode::TranslatedString(node) => write!(f, "{:?}", node),

            // stmt
            AstNode::CaseStatement(node) => write!(f, "{:?}", node),
            AstNode::Command(node) => write!(f, "{:?}", node),
            AstNode::CompoundStatement(node) => write!(f, "{:?}", node),
            AstNode::CStyleForStatement(node) => write!(f, "{:?}", node),
            AstNode::DeclarationCommand(node) => write!(f, "{:?}", node),
            AstNode::ForStatement(node) => write!(f, "{:?}", node),
            AstNode::FunctionDefinition(node) => write!(f, "{:?}", node),
            AstNode::IfStatement(node) => write!(f, "{:?}", node),
            AstNode::List(node) => write!(f, "{:?}", node),
            AstNode::NegatedCommand(node) => write!(f, "{:?}", node),
            AstNode::Pipeline(node) => write!(f, "{:?}", node),
            AstNode::RedirectedStatement(node) => write!(f, "{:?}", node),
            AstNode::Subshell(node) => write!(f, "{:?}", node),
            AstNode::TestCommand(node) => write!(f, "{:?}", node),
            AstNode::UnsetCommand(node) => write!(f, "{:?}", node),
            AstNode::VariableAssignment(node) => write!(f, "{:?}", node),
            AstNode::VariableAssignments(node) => write!(f, "{:?}", node),
            AstNode::WhileStatement(node) => write!(f, "{:?}", node),

            // other
            AstNode::Array(node) => write!(f, "{:?}", node),
            AstNode::CaseItem(node) => write!(f, "{:?}", node),
            AstNode::CommandName(node) => write!(f, "{:?}", node),
            AstNode::Comment(node) => write!(f, "{:?}", node),
            AstNode::DoGroup(node) => write!(f, "{:?}", node),
            AstNode::ElifClause(node) => write!(f, "{:?}", node),
            AstNode::ElseClause(node) => write!(f, "{:?}", node),
            AstNode::ExtglobPattern(node) => write!(f, "{:?}", node),
            AstNode::FileDescriptor(node) => write!(f, "{:?}", node),
            AstNode::FileRedirect(node) => write!(f, "{:?}", node),
            AstNode::HeredocBody(node) => write!(f, "{:?}", node),
            AstNode::HeredocContent(node) => write!(f, "{:?}", node),
            AstNode::HeredocEnd(node) => write!(f, "{:?}", node),
            AstNode::HeredocRedirect(node) => write!(f, "{:?}", node),
            AstNode::HeredocStart(node) => write!(f, "{:?}", node),
            AstNode::HerestringRedirect(node) => write!(f, "{:?}", node),
            AstNode::Regex(node) => write!(f, "{:?}", node),
            AstNode::SpecialVariableName(node) => write!(f, "{:?}", node),
            AstNode::StringContent(node) => write!(f, "{:?}", node),
            AstNode::Subscript(node) => write!(f, "{:?}", node),
            AstNode::TestOperator(node) => write!(f, "{:?}", node),
            AstNode::VariableName(node) => write!(f, "{:?}", node),
        }
    }
}


// meta data

// pub struct NodeMeta {
//     pub syntax: SyntaxInfo,
// }

// impl std::fmt::Debug for NodeMeta {
//     fn fmt(
//         &self,
//         f: &mut std::fmt::Formatter<'_>,
//     ) -> std::fmt::Result {
//         write!(f, "{:?}", self.syntax)
//     }
// }

pub struct SyntaxInfo {
    pub raw: String,
    pub start_byte: usize,
    pub end_byte: usize,
}

impl std::fmt::Debug  for SyntaxInfo {
    fn fmt(&self, f: &mut std::fmt::Formatter<'_>) -> std::fmt::Result {
        write!(f, "{{ raw: {:?}, start_byte: {}, end_byte: {} }}", self.raw, self.start_byte, self.end_byte)
    }
}

