using System;
using System.Collections.Generic;

class StackExample {
    static void Main() {
        Stack<int> stack = new Stack<int>();

        // Push items onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peek at the top item on the stack
        Console.WriteLine(stack.Peek()); // Output: 3

        // Pop items off the stack
        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Pop()); // Output: 2
    }
}
