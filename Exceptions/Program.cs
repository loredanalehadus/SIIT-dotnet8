// See https://aka.ms/new-console-template for more information

using Exceptions;
Console.WriteLine($"The result is: {Add()} ");
//PrintText();

Person invalidPerson = new Person("gigi", -2);


// methods
static int Add()
{
    int a = 0;
    int b = 0;

    bool isAValid = false;
    bool isBValid = false;

    do
    {
        try
        {
            a = int.Parse(Console.ReadLine());
            isAValid = true;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.StackTrace);
            //Console.WriteLine($"Your first input is in invalid format. Please enter a valid integer number. {ex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("This cleanup code is ALWAYS executed.");
        }

    } while (!isAValid);


    do
    {
        try
        {
            b = int.Parse(Console.ReadLine());
            isBValid = true;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Your second input is in invalid format. Please enter a valid integer number");
            //Console.WriteLine($"For more info read this: {ex.Message} /n {ex.Source}, /n {ex.StackTrace}");
        }
    } while (!isBValid);

    return a + b;
}

static void PrintText()
{
    throw new PrintingException("Unable to the print the message");
}