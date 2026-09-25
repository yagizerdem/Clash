#include "parser.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <tree_sitter/api.h>
#include <tree_sitter/tree-sitter-bash.h>


TSTree* bashParser(const char *source) {
    if (source == NULL) {
        perror("cannot parse null source code");
        exit(-1);
    }
    if (strlen(source) > UINT32_MAX) {
        perror("string too long");
        exit(-1);
    }

    TSParser *parser = ts_parser_new();
    if (parser == NULL) {
        perror("cannot create parser");
        exit(-1);
    }

    // Set the parser's language (JSON in this case).
    const bool flag = ts_parser_set_language(parser, tree_sitter_bash());
    if (!flag) {
        perror("cannot set language");
        exit(-1);
    }

    // Build a syntax tree based on source code stored in a string.
    TSTree *tree = ts_parser_parse_string(
      parser,
      NULL,
      source,
      strlen(source)
    );

    if (tree == NULL) {
        perror("cannot parse string");
        exit(-1);
    }

    return tree;
}

void checkSyntax(const TSTree* tree) {
    if (tree == NULL) {
        perror("cannot parse null tree");
        exit(-1);
    }

    TSNode root = ts_tree_root_node(tree);
}


char* serializeTsNode(const TSNode node) {
    char* serialized = ts_node_string(node);
    return serialized;
}

