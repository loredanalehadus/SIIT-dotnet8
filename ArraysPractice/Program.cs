using System;
using System.Text;

public static class Program
{

    //entry point of the application
    public static void Main()
    {
        // Reverse and print the following array
        // declare the array
        int[] array = { 1, 2, 3, 4, 5 };

        //call the method
        //PrintReverseArray1(array);
        //PrintReverseArray2(array);
        //ReadAndPrintWorkDays();

        // clone vs copy
        int[] copyArray = new int[5];
        // copies the reference and the values
        //copyArray = array;

        // copies only the values
        copyArray = (int[])array.Clone();

        copyArray[0] = 250;

        foreach (int i in array)
        {
            // Console.Write(i);
        }

        // reading and printing matrix
        //int[,] myMatrix = ReadMatrix();
        //PrintMatrix(myMatrix);

        // reversed the array using Array.Reverse();
        //PrintReverseArray3(array);

        // get the index of the given week day -> e.g. miercuri

        //string[] days = { "luni", "marti", "miercuri", "duminica" };
        //int miercuri = Array.IndexOf(days, "miercuri");

        //Console.WriteLine(miercuri);

        string[] daysDuplicate = { "luni", "marti", "miercuri", "duminica", "miercuri", "miercuri" };
        int miercuri2 = Array.LastIndexOf(daysDuplicate, "miercuri");
        Console.WriteLine(miercuri2);

        for (int i = 0; i < daysDuplicate.Length; i++)
        {
            // replace the duplicate element with something else
            bool isDuplicate = Array.IndexOf(daysDuplicate, daysDuplicate[i]) != 
                Array.LastIndexOf(daysDuplicate, daysDuplicate[i]);
                        
            if (isDuplicate)
            {
                int indexOfDuplicate = Array.IndexOf(daysDuplicate, daysDuplicate[i]);
                daysDuplicate[indexOfDuplicate] = "bla";
            }
        }

        // null array
        int[] nullArray;

        //empty array
        int[] emptyArray = new int[3];
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintReverseArray1(int[] array)
    {
        int length = array.Length;
        //declare and create the reversed array
        int[] reversedArray = new int[length];

        //initialize the array
        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = array[length - i - 1];
            Console.WriteLine(reversedArray[i]);
        }
    }

    static void PrintReverseArray2(int[] array)
    {
        int[] reversedArray = new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversedArray[array.Length - i - 1] = array[i];
        }

        Console.Write(reversedArray); // this will print the type System.Int32[]

        for (int index = 0; index < reversedArray.Length; index++)
        {
            Console.Write(reversedArray[index]);
        }
    }

    static void PrintReverseArray3(int[] array)
    {
        foreach (int element in array.Reverse())
        {
            Console.Write(element + ", ");
        }
    }

    static void ReadAndPrintWorkDays()
    {
        //first ask for the lenght of the array
        Console.WriteLine("Type the lenght of the array: ");
        int length = int.Parse(Console.ReadLine());

        //netx ask for the elements of the array
        Console.WriteLine("Type the elements of the array: ");

        string[] workDays = new string[length];
        for (int i = 0; i < length; i++)
        {
            workDays[i] = Console.ReadLine();
        }

        StringBuilder workDaysList = new StringBuilder();

        //for (int index = 0; index < workDays.Length; index += 3)
        //{
        //    workDaysList.Append(workDays[index]).Append(", ");
        //}

        foreach (string day in workDays)
        {
            workDaysList.Append(day).Append(" ");
        }

        Console.WriteLine(workDaysList.ToString());
    }

    static int[,] ReadMatrix()
    {
        Console.WriteLine("Set the rows length: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Set the columns lenght: ");
        int columns = int.Parse(Console.ReadLine());

        //inline initialization
        //int[,] matrix = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };

        //define the matrix
        int[,] matrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }
}