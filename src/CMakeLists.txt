add_executable(Clash
    main.c
        stack-trace/stack_trace.cpp
    backward/backward.cpp
        stack-trace/crash-handler.cpp
        stack-trace/crash_handler.h
)

if(WIN32)
    target_link_libraries(Clash PRIVATE dbghelp)
endif()
