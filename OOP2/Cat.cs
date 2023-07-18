public class Cat : Animal
{
    public override void Sleep(int milliseconds)
    {
        Console.WriteLine($"My CAT sleeps this much: {milliseconds}.");
    }

    public override void Eat()
    {
        Console.WriteLine("I like to eat my prey");
    }
}