public class Program
{
    public static void Main()
    {
        //SimpleIfStatement();

        //nested if

        //ElseIfSequence();
        //Switch();

        //Operators();

        // while loop

        int x = 5;

        while (/*condition*/ x > 0)
        {
            //do something
            Console.WriteLine(x);
            x--;
        }
        
        Console.WriteLine("outside while");

        int y = 5;

        do
        {
            //do something
            Console.WriteLine(y);
            y--;
        }
        while (y > 0);

        Console.WriteLine("outside do while");

    }


    public static void SimpleIfStatement()
    {
        int x = 2;

        if (x > 3) //condition
        {
            // ramura yes; conditia mea a fost indeplinita
            Console.WriteLine("X is grater than 3");
        }
        else
        {
            // ramura no; conditia nu este indeplinita
            Console.WriteLine("X is smaller or equal than 3");
        }

        if (x == 3)
        {
            Console.WriteLine("X is equal to 3");
        }
    }

    public static void NestedIf()
    {
        int first = 5;
        int second = 3;

        if (first == second)
        {
            Console.WriteLine("These two are equal");
        }
        else if (first > second)
        {
            Console.WriteLine("First is grater");
        }
        else
        {
            Console.WriteLine("Second is grater");
        }
    }

    public static void AvoidNestedIf()
    {
        int first = 5;
        int second = 3;

        if (first == second)
        {
            Console.WriteLine("These two are equal");
            return; // method exists
        }

        if (first > second)
        {
            Console.WriteLine("First is grater");
        }
        else
        {
            Console.WriteLine("Second is grater");
        }
    }

    public static void ElseIfSequence()
    {
        char ch = 'X';
        if (ch == 'A' || ch == 'a')
        {
            Console.WriteLine("Vowel [ei]");
        }
        else if (ch == 'E' || ch == 'e')
        {
            Console.WriteLine("Vowel [i:]");
        }
        else if (ch == 'I' || ch == 'i')
        {
            Console.WriteLine("Vowel [ai]");
        }
        else if (ch == 'O' || ch == 'o')
        {
            Console.WriteLine("Vowel [ou]");
        }
        else if (ch == 'U' || ch == 'u')
        {
            Console.WriteLine("Vowel [ju:]");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }

    //alternativa la else-if sequences
    public static void Switch()
    {
        char ch = 'X';

        switch (ch) //variabila pe care o validez
        {
            case 'A':
            case 'a':
                Console.WriteLine("Vowel [ei]");
                break;
            case 'E':
            case 'e':
                Console.WriteLine("Vowel [i:]");
                break;
            case 'I':
            case 'i':
                Console.WriteLine("Vowel [ai]");
                break;
            //...
            // fill in all the vowels
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }

    public static void Operators()
    {
        // sau ||
        // si  &&

        if (true && false) // false
        {
        }

        if (true || false) // true
        {

            Console.WriteLine("True");
        }

        if (true && true) // true
        {
            Console.WriteLine("True");
        }

        if (true || true) // true
        {
            Console.WriteLine("True");
        }

        if (false && false) // false
        {
        }

        if (false || false) // false
        {
        }


    }
}