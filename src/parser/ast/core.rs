use crate::parser::ast::expr::BinaryExpr;


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
    BinaryExpr(BinaryExpr)
}


impl std::fmt::Debug for AstNode {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        match self {
            AstNode::BinaryExpr(expr) => {
                write!(f, "{:?}", expr)
            }
        }
    }
}


// meta data

pub struct NodeMeta {
    pub syntax: SyntaxInfo,
}

impl std::fmt::Debug for NodeMeta {
    fn fmt(
        &self,
        f: &mut std::fmt::Formatter<'_>,
    ) -> std::fmt::Result {
        write!(f, "{:?}", self.syntax)
    }
}

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

