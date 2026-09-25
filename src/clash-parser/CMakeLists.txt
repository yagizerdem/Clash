add_library(clash-parser SHARED
        parser.h
        parser.c
)

target_link_libraries(clash-parser PUBLIC tree-sitter tree-sitter-bash)

target_link_libraries(Clash
        PRIVATE
        clash-parser
)
