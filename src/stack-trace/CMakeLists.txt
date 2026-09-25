add_library(stack-trace SHARED
        stack_trace.cpp
        stack_trace.h
        crash-handler.cpp
        crash_handler.h
)

target_link_libraries(stack-trace
        PRIVATE
        Backward::Backward
)

target_link_libraries(Clash
        PRIVATE
        stack-trace
)