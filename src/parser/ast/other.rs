use crate::parser::ast::core::*;
use crate::parser::ast::ast_enum::*;

pub struct Array {
    pub elements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Array {
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


pub struct CaseItem {
    pub values: Vec<AstNode>,
    pub statements: Vec<AstNode>,
    pub terminator: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CaseItem {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ values: {:?}, statements: {:?}, terminator: {:?}, syntax_info: {:?} }}",
            self.values,
            self.statements,
            self.terminator,
            self.syntax_info
        )
    }
}


pub struct CommandName {
    pub value: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CommandName {
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

pub struct Comment {
    pub content: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Comment {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ content: {:?}, syntax_info: {:?} }}",
            self.content,
            self.syntax_info
        )
    }
}

pub struct DoGroup {
    pub statements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for DoGroup {
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


pub struct ElifClause {
    pub condition: Vec<AstNode>,
    pub then_branch: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ElifClause {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ condition: {:?}, then_branch: {:?}, syntax_info: {:?} }}",
            self.condition,
            self.then_branch,
            self.syntax_info
        )
    }
}


pub struct ElseClause {
    pub statements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ElseClause {
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


pub struct ExtglobPattern {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ExtglobPattern {
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


pub struct FileDescriptor {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for FileDescriptor {
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

pub struct FileRedirect {
    pub descriptor: Option<Box<AstNode>>,
    pub operator: RedirectionKind,
    pub destinations: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for FileRedirect {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ descriptor: {:?}, operator: {:?}, destinations: {:?}, syntax_info: {:?} }}",
            self.descriptor,
            self.operator,
            self.destinations,
            self.syntax_info
        )
    }
}

use crate::parser::ast::core::*;

pub struct HeredocBody {
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HeredocBody {
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

pub struct HeredocContent {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HeredocContent {
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

pub struct HeredocEnd {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HeredocEnd {
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

pub struct HeredocRedirect {
    pub descriptor: Option<Box<AstNode>>,
    pub redirect_operator: RedirectionKind,
    pub arguments: Vec<AstNode>,
    pub operator: Option<String>,
    pub redirects: Vec<AstNode>,
    pub right: Option<Box<AstNode>>,
    pub parts: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HeredocRedirect {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ descriptor: {:?}, redirect_operator: {:?}, arguments: {:?}, operator: {:?}, redirects: {:?}, right: {:?}, parts: {:?}, syntax_info: {:?} }}",
            self.descriptor,
            self.redirect_operator,
            self.arguments,
            self.operator,
            self.redirects,
            self.right,
            self.parts,
            self.syntax_info
        )
    }
}

pub struct HeredocStart {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HeredocStart {
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

pub struct HerestringRedirect {
    pub descriptor: Option<Box<AstNode>>,
    pub value: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for HerestringRedirect {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ descriptor: {:?}, value: {:?}, syntax_info: {:?} }}",
            self.descriptor,
            self.value,
            self.syntax_info
        )
    }
}

pub struct Regex {
    pub regex: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Regex {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ regex: {:?}, syntax_info: {:?} }}",
            self.regex,
            self.syntax_info
        )
    }
}

pub struct SpecialVariableName {
    pub identifier: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for SpecialVariableName {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ identifier: {:?}, syntax_info: {:?} }}",
            self.identifier,
            self.syntax_info
        )
    }
}

pub struct StringContent {
    pub value: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for StringContent {
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

pub struct Subscript {
    pub name: Box<AstNode>,
    pub index: Box<AstNode>,
    pub suffix: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Subscript {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ name: {:?}, index: {:?}, suffix: {:?}, syntax_info: {:?} }}",
            self.name,
            self.index,
            self.suffix,
            self.syntax_info
        )
    }
}

pub struct TestOperator {
    pub operator: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for TestOperator {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ operator: {:?}, syntax_info: {:?} }}",
            self.operator,
            self.syntax_info
        )
    }
}

pub struct VariableName {
    pub identifier: String,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for VariableName {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ identifier: {:?}, syntax_info: {:?} }}",
            self.identifier,
            self.syntax_info
        )
    }
}

