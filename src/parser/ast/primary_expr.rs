use crate::parser::ast::core::*;


pub struct AnsiCString {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for AnsiCString {
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



pub struct ArithmeticExpansion {
    pub expressions: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ArithmeticExpansion {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ expressions: {:?}, syntax_info: {:?} }}",
            self.expressions,
            self.syntax_info
        )
    }
}

pub struct BraceExpression {
    pub elements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for BraceExpression {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ elements: {:?}, syntax_info: {:?} }}",
            self.elements,
            self.syntax_info
        )
    }
}

pub struct CommandSubstitution {
    pub statements: Vec<AstNode>,
    pub redirect: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CommandSubstitution {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ statements: {:?}, redirect: {:?}, syntax_info: {:?} }}",
            self.statements,
            self.redirect,
            self.syntax_info
        )
    }
}


pub struct Expansion {
    pub operator: Vec<String>,
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Expansion {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ operator: {:?}, parts: {:?}, syntax_info: {:?} }}",
            self.operator,
            self.parts,
            self.syntax_info
        )
    }
}


pub struct Number {
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Number {
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

pub struct ProcessSubstitution {
    pub statements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ProcessSubstitution {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ statements: {:?}, syntax_info: {:?} }}",
            self.statements,
            self.syntax_info
        )
    }
}


pub struct RawString {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for RawString {
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

pub struct SimpleExpansion {
    pub variable: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for SimpleExpansion {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ variable: {:?}, syntax_info: {:?} }}",
            self.variable,
            self.syntax_info
        )
    }
}

pub struct StringNode {
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for StringNode {
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

pub struct TranslatedString {
    pub value: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for TranslatedString {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ value: {:?}, syntax_info: {:?} }}",
            self.value,
            self.syntax_info
        )
    }
}

