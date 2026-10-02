use tree_sitter::Parser;
use tree_sitter_bash;

pub struct BashParser {
    parser: Parser,
}

impl BashParser {
    pub fn new() -> Self {
        let mut parser = Parser::new();

        parser
            .set_language(&tree_sitter_bash::LANGUAGE.into())
            .expect("failed to load Bash grammar");

        Self { parser }
    }

    pub fn parse(&mut self, source: &str) -> tree_sitter::Tree{
        let tree = self.parser.parse(source, None).unwrap();
        return tree;
    }
}