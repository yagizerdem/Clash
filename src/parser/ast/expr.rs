use crate::parser::ast::core::*;

pub struct BinaryExpr {
    pub left: Box<AstNode>,
    pub operator: String,
    pub right: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for BinaryExpr {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ left: {:?}, operator: {:?}, right: {:?}, syntax_info: {:?} }}",
            self.left,
            self.operator,
            self.right,
            self.syntax_info
        )
    }
}

pub struct Concatenation {
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Concatenation {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ parts: {:?}, syntax_info: {:?} }}",
            self.parts,
            self.syntax_info
        )
    }
}

pub struct ParenthesizedExpression {
    pub expression: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ParenthesizedExpression {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ expression: {:?}, syntax_info: {:?} }}",
            self.expression,
            self.syntax_info
        )
    }
}

pub struct PostfixExpression {
    pub operand: Box<AstNode>,
    pub operator: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for PostfixExpression {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ operand: {:?}, operator: {:?}, syntax_info: {:?} }}",
            self.operand,
            self.operator,
            self.syntax_info
        )
    }
}

pub struct TernaryExpression {
    pub condition: Box<AstNode>,
    pub consequence: Box<AstNode>,
    pub alternative: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for TernaryExpression {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ condition: {:?}, consequence: {:?}, alternative: {:?}, syntax_info: {:?} }}",
            self.condition,
            self.consequence,
            self.alternative,
            self.syntax_info
        )
    }
}

pub struct UnaryExpression {
    pub operator: String,
    pub operand: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for UnaryExpression {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ operator: {:?}, operand: {:?}, syntax_info: {:?} }}",
            self.operator,
            self.operand,
            self.syntax_info
        )
    }
}

pub struct Word {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Word {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ syntax_info: {:?} }}",
            self.syntax_info
        )
    }
}
