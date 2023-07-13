using Interfaces;

public class Program
{
    public static void Main()
    {
        Ferrari myFerrari = new Ferrari("488-Spider");

        Console.WriteLine($"My Ferrari Model: {myFerrari.Model}");

        myFerrari.UseBrakes();
        myFerrari.PushGasPedal();
    }
}