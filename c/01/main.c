#include <stdio.h>

#define MAX_LEN 25

int main(int argc, char* argv[])
{
    char name[MAX_LEN];

    printf("What is your name? ");
    scanf("%s", name);
    printf("Hello, %s, nice to meet you!\n", name);

    return 0;
}