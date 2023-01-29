
using System;
using System.Collections.Generic;

class QueueExample {
    static void Main() {
        Queue<string> queue = new Queue<string>();

        // Enqueue items onto the queue
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        // Peek at the first item in the queue
        Console.WriteLine(queue.Peek()); // Output: First

        // Dequeue items from the queue
        Console.WriteLine(queue.Dequeue()); // Output: First
        Console.WriteLine(queue.Dequeue()); // Output: Second
    }
}
