#include "stack-trace/crash_handler.h"
#include  <stdio.h>
#include "tree-sitter-bash/src/tree_sitter/parser.h"

const TSLanguage *tree_sitter_bash(void);

int main(void) {
    clash_install_crash_handler();
    printf("test");




    return 0;
}
