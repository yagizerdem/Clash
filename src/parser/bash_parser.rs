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


pub fn print_formatted(tree: &tree_sitter::Tree) {
    let node = tree.root_node();
    print_formatted_recursive(node, 0);
}


pub fn print_formatted_recursive(node: tree_sitter::Node,  depth: usize) {
    print!("{} {:?}", " ".repeat(depth), node);

    for i in 0..node.child_count() {
        if let Some(child) = node.child(i) {
            print_formatted_recursive(child, depth + 2);
        }
    }
}
