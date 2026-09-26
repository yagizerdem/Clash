#include "stack-trace/crash_handler.h"
#include  <stdio.h>
#include  "clash-parser/parser.h"

int main(void) {
    clash_install_crash_handler();

    const TSTree* tree = bashParser("for i in $(seq 1 10;\ndo\n    echo $i\ndone");
    const TSNode root = ts_tree_root_node(tree);
    printf("%s\n", serializeTsNode(root));
    checkSyntax(tree);

    return 0;
}
