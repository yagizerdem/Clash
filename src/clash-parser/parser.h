#ifndef CLASH_PARSER_H
#define CLASH_PARSER_H
#include <tree_sitter/api.h>

TSTree* bashParser(const char *source);

void checkSyntax(const TSTree* tree);

char* serializeTsNode(TSNode node);

#endif //CLASH_PARSER_H
