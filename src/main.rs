mod parser;

fn main() {
  let mut parser = parser::BashParser::new();

  let src_code =  "echo Hello, world!";
  let root_node = parser.parse(src_code);
  println!("Root node: {:?}", root_node);
}



