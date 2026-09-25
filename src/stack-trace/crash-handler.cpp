#include <memory>

#include "../backward/backward.hpp"

static std::unique_ptr<backward::SignalHandling> handler;

extern "C" void clash_install_crash_handler(void)
{
    handler = std::make_unique<backward::SignalHandling>();
}