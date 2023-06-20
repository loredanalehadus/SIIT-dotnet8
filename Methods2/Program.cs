public static class Program
{
    /* Write a method GetMin() with two parameters that returns 
     * the smallest of two integers. Write a
     method that reads 2 integers from the console and prints the smalles of them using the
     method GetMin(). */

    public static void Main()
    {
        //PrintMin();
        PrintMinFloat();
        //todo: use the method from ex 3
    }

    static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }

        return b;
    }

    static void PrintMin()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int min = GetMin(a, b);

        Console.WriteLine($"Min between {a} and {b} is {min}");
        Console.WriteLine($"Min between {a} and {b} is {GetMin(a, b)}");
    }

    //Exercise 2:
    //TODO: Create a method that overloads
    //the previous oneso that it can receive float numbers

    static float GetMin(float a, float b)
    {
        if (a < b)
        {
            return a;
        }

        return b;
    }

    static void PrintMinFloat()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        float min = GetMin(a, b);

        Console.WriteLine($"Min between {a} and {b} is {min}");
        Console.WriteLine($"Min between {a} and {b} is {GetMin(a, b)}");
    }


    //Exercise 3:
    //TODO: Create a method that overloads
    //the previous oneso that it can receive decimal numbers

    //TODO: input your method






}