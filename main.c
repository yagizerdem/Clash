#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <string.h>
#include <unistd.h>
#include <wait.h>

int main(void) {



    pid_t pid = fork();
    if (pid == -1) {
        perror("fork");
    }
    else if (pid == 0) {

        char *arg[6] = {"/bin/bash", "-c", "echo yagiz erdem", NULL} ;
        char *env[] = { NULL };

        execve(arg[0], arg, env);
        perror("execve");   /* execve() returns only on error */
        exit(EXIT_FAILURE);

    }
    else {
        printf("parent %d \n", pid);
        wait(NULL);
    }


    return 0;
};
