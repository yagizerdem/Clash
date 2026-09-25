add_executable(Clash main.c)

if(WIN32)
    target_link_libraries(Clash PRIVATE dbghelp)
endif()

#debug
add_subdirectory(backward)
add_subdirectory(stack-trace)

#frontend
add_subdirectory(tree-sitter)
add_subdirectory(tree-sitter-bash)
add_subdirectory(clash-parser)
