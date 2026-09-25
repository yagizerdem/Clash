#include "./stack_trace.h"
#include "../backward/backward.hpp"

extern "C" void clash_print_stack_trace(void) {
    backward::Printer printer;
    backward::StackTrace trace;
#ifdef BACKWARD_SYSTEM_WINDOWS
    trace.set_machine_type(printer.resolver().machine_type());
#endif
    trace.load_here(32);
    trace.skip_n_firsts(1);
    printer.print(trace, stderr);
}
