public class Dog : Animal
{     

    public override void Sleep(int milliseconds)
    {
        Console.WriteLine($"My Dog sleeps this much: {milliseconds}.");
    }

    public void Sleep(float time)
    {
        Console.WriteLine($"Overloaded method of sleep: {time}.");
    }
}
