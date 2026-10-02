use crate::parser::ast::core::*;


pub struct CaseStatement {
    pub value: Box<AstNode>,
    pub items: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CaseStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ value: {:?}, items: {:?}, syntax_info: {:?} }}",
            self.value,
            self.items,
            self.syntax_info
        )
    }
}


pub struct Command {
    pub name: Box<AstNode>,
    pub arguments: Vec<AstNode>,
    pub redirects: Vec<AstNode>,
    pub prefixes: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Command {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ name: {:?}, arguments: {:?}, redirects: {:?}, prefixes: {:?}, syntax_info: {:?} }}",
            self.name,
            self.arguments,
            self.redirects,
            self.prefixes,
            self.syntax_info
        )
    }
}


pub struct CompoundStatement {
    pub elements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CompoundStatement {
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


pub struct CStyleForStatement {
    pub initializer: Vec<AstNode>,
    pub condition: Vec<AstNode>,
    pub update: Vec<AstNode>,
    pub body: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for CStyleForStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ initializer: {:?}, condition: {:?}, update: {:?}, body: {:?}, syntax_info: {:?} }}",
            self.initializer,
            self.condition,
            self.update,
            self.body,
            self.syntax_info
        )
    }
}


pub struct DeclarationCommand {
    pub declaration_kind: DeclarationKind,
    pub arguments: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for DeclarationCommand {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ declaration_kind: {:?}, arguments: {:?}, syntax_info: {:?} }}",
            self.declaration_kind,
            self.arguments,
            self.syntax_info
        )
    }
}


pub struct ForStatement {
    pub variable: Box<AstNode>,
    pub values: Vec<AstNode>,
    pub body: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for ForStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ variable: {:?}, values: {:?}, body: {:?}, syntax_info: {:?} }}",
            self.variable,
            self.values,
            self.body,
            self.syntax_info
        )
    }
}


pub struct FunctionDefinition {
    pub name: Box<AstNode>,
    pub body: Box<AstNode>,
    pub redirects: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for FunctionDefinition {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ name: {:?}, body: {:?}, redirects: {:?}, syntax_info: {:?} }}",
            self.name,
            self.body,
            self.redirects,
            self.syntax_info
        )
    }
}


pub struct IfStatement {
    pub condition: Vec<AstNode>,
    pub then_branch: Vec<AstNode>,
    pub elif_clauses: Vec<AstNode>,
    pub else_clause: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for IfStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ condition: {:?}, then_branch: {:?}, elif_clauses: {:?}, else_clause: {:?}, syntax_info: {:?} }}",
            self.condition,
            self.then_branch,
            self.elif_clauses,
            self.else_clause,
            self.syntax_info
        )
    }
}


pub struct List {
    pub statements: Vec<AstNode>,
    pub operators: Vec<ListOperator>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for List {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ statements: {:?}, operators: {:?}, syntax_info: {:?} }}",
            self.statements,
            self.operators,
            self.syntax_info
        )
    }
}



pub struct NegatedCommand {
    pub command: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for NegatedCommand {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ command: {:?}, syntax_info: {:?} }}",
            self.command,
            self.syntax_info
        )
    }
}


pub struct Pipeline {
    pub commands: Vec<AstNode>,
    pub operators: Vec<PipeOperator>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Pipeline {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ commands: {:?}, operators: {:?}, syntax_info: {:?} }}",
            self.commands,
            self.operators,
            self.syntax_info
        )
    }
}


pub struct RedirectedStatement {
    pub body: Box<AstNode>,
    pub redirects: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for RedirectedStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ body: {:?}, redirects: {:?}, syntax_info: {:?} }}",
            self.body,
            self.redirects,
            self.syntax_info
        )
    }
}


pub struct Subshell {
    pub statements: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for Subshell {
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


pub struct TestCommand {
    pub expression: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for TestCommand {
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

pub struct UnsetCommand {
    pub targets: Vec<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for UnsetCommand {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ targets: {:?}, syntax_info: {:?} }}",
            self.targets,
            self.syntax_info
        )
    }
}


pub struct VariableAssignment {
    pub name: Box<AstNode>,
    pub value: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for VariableAssignment {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ name: {:?}, value: {:?}, syntax_info: {:?} }}",
            self.name,
            self.value,
            self.syntax_info
        )
    }
}


pub struct VariableAssignments {
    pub assignments: Vec<VariableAssignment>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for VariableAssignments {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ assignments: {:?}, syntax_info: {:?} }}",
            self.assignments,
            self.syntax_info
        )
    }
}


pub struct WhileStatement {
    pub loop_kind: LoopKind,
    pub condition: Vec<AstNode>,
    pub body: Box<AstNode>,
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for WhileStatement {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(
            f,
            "{{ loop_kind: {:?}, condition: {:?}, body: {:?}, syntax_info: {:?} }}",
            self.loop_kind,
            self.condition,
            self.body,
            self.syntax_info
        )
    }
}