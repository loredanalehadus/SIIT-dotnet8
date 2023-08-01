//declare the message queue
Queue<string> messageQueue = new Queue<string>();

// add messages to the queue
messageQueue.Enqueue("message 1");
messageQueue.Enqueue("message 2");
messageQueue.Enqueue("message 3");
messageQueue.Enqueue("message 4");

Console.WriteLine("Peek the first element in the queue is: " + messageQueue.Peek());

while (messageQueue.Count > 0)
{
    Console.WriteLine($"next in line is: {messageQueue.Dequeue()}");
}