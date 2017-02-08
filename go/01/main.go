package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	reader := bufio.NewReader(os.Stdin)
	fmt.Print("What is your name? ")
	name, _ := reader.ReadString('\n')
	name = strings.Replace(name, "\n", "", -1)
	fmt.Print("Hello, ", name, ", nice to meet you!\n")
}
