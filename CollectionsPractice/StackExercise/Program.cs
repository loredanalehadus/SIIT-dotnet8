// Write a program, which reads from the console N integers and
// prints them in reversed order. Use the Stack<int> class.

Console.WriteLine("Enter the number of integers (N):");
int n = int.Parse(Console.ReadLine());

Stack<int> numberStack = new Stack<int>();

Console.WriteLine($"Enter {n} integers:");

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    numberStack.Push(number);
}

Console.WriteLine("Reversed order:");

while (numberStack.Count > 0)
{
    int number = numberStack.Pop();
    Console.Write(number + " ");
}

