public class Program
{
    public static void Main()
    {
        Stack<string> cities = new Stack<string>();
        cities.Push("1. Iasi");
        cities.Push("2. Cluj");
        cities.Push("3. Bucuresti");
        cities.Push("4. Oradea");

        string lastElement = cities.Peek();

        Console.WriteLine("Last element is: " + lastElement);

        while (cities.Count > 0)
        {
            var currentCity = cities.Pop();
            Console.WriteLine(currentCity);
        }
    }
}