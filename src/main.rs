
mod parser;

fn main() {
  let mut parser = parser::BashParser::new();

  let src_code =  "echo Hello, world!;";
  let ts_tree = parser.parse(src_code);

  parser::print_formatted(&ts_tree);



}



