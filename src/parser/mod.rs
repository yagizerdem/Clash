mod bash_parser;
pub mod ast;
mod clash_parser;

pub use bash_parser::{BashParser, print_formatted, print_formatted_recursive};
