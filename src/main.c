#include "stack-trace/crash_handler.h"
#include  <stdio.h>

int main(void) {
    clash_install_crash_handler();
    printf("test");
    int *x = NULL;
    *x = 10;
    return 0;
}
