use std::vec;

mod parser;

fn main() {
  let mut parser = parser::BashParser::new();

  let src_code =  "echo Hello, world!;";
  let root_node = parser.parse(src_code);

  let a: parser::ast::Program = parser::ast::Program {
    statements: vec![parser::ast::AstNode {
      syntax_info: parser::ast::SyntaxInfo {
        raw: "echo Hello, world!".to_string(),
        start_byte: 0,
        end_byte: 18,
      },
    },
    parser::ast::AstNode {
      syntax_info: parser::ast::SyntaxInfo {
        raw: "echo yagiz erdem".to_string(),
        start_byte: 0,
        end_byte: 18,
      },
    }]
  };

  println!("{:?}", a);

}



