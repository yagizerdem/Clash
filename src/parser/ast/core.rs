
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



pub struct AstNode {
    pub syntax_info: SyntaxInfo,
}

impl std::fmt::Debug for AstNode {
    fn fmt(&self, f: &mut std::fmt::Formatter<'_>) -> std::fmt::Result {
        write!(f, "{:?}", self.syntax_info)
    }
}