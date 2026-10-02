use std::vec;

mod parser;

fn main() {
  let mut parser = parser::BashParser::new();

  let src_code =  "echo Hello, world!;";
  let root_node = parser.parse(src_code);


  let a : parser::ast::BinaryExpr = parser::ast::BinaryExpr {
    left: Box::new(parser::ast::AstNode::RawString(parser::ast::RawString {
      syntax_info: parser::ast::SyntaxInfo {
        end_byte:0,
        start_byte:0,
        raw: "hello".to_string(),
      },
    })), // Replace with actual left expression
    right: vec![], // Replace with actual right expression
    operator: "+".to_string(), // Replace with actual operator
    syntax_info: parser::ast::SyntaxInfo {
        end_byte:0,
        start_byte:0,
        raw: "hello".to_string(),
      }, // Replace with actual syntax info
  };


  println!("{:?}", a); 


}



