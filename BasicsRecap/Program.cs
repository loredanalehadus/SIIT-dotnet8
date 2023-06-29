using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System;
using System.Text;

public static class Program
{
    public static void Main()
    {
        //CreateAndPrintArray();

        int[] array = { 1, 2, 3, 4, 3, 5, 2, 3, 3, 1 };

        //SumArrayElements();

        //Input: 1 34 5 67 7 9 10
        int[] secondArray = ReadArrayFromConsole();
        //  SortArrayWithBuiltInFunc(secondArray);

        SortArrayWithBubbleSort(secondArray);
        PrintArray(secondArray);
    }

    // Write a method to create an array of 5 integers and display the array items.
    // Access individual elements and display them through indexes.
    public static void CreateAndPrintArray()
    {
        //declare and assign values to the array
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 }; ;

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write(numbers[index]);
        }
    }

    // Write a program that reads n numbers and outputs their sum
    public static int SumArrayElements()
    {
        Console.WriteLine("Introduce the length of the array: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        Console.WriteLine($"Sum of the array elements is: {sum}");
        return sum;
    }


    //Input: 1 34 5 67 7 9 10
    public static int[] ReadArrayFromConsole()
    {
        Console.WriteLine("Type the numbers seppared by space");
        string input = Console.ReadLine();

        string[] splittedArray = input.Split(' ');
        int[] array = new int[splittedArray.Length];

        for (int i = 0; i < splittedArray.Length; i++)
        {
            array[i] = int.Parse(splittedArray[i]);
        }

        return array;
    }

    public static void PrintArray(int[] array)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("[")
            .AppendJoin(", ", array)
            .Append("]");

        Console.WriteLine(builder);
    }

    //Write a program that reads the elements of an array of integer numbers, sorts the array and
    //    then prints them back on the console.The numbers should be entered from the console on a single line,
    //    separated by a space.
    //    Print the sorted array in the following format: “[element1, element2...elementN]”.
    //    Condition: Do not use the built-in sorting method, you should write the logic yourself.
    //    Use the bubble sort algorithm.


    public static int[] SortArrayWithBuiltInFunc(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    public static void SortArrayWithBubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                int temp = array[j];
             if (array[j] > array[j + 1])
                {
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

}



