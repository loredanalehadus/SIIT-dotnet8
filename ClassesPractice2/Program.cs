using ClassesPractice2;
using ClassesPractice2.Enumerations;

public static class Program
{
    public static void Main()
    {
        //dates and times samples
        //DateAndTimes myDates = new DateAndTimes();
        //myDates.PrintMyDates();


        //Model the Rabbit class knowing that:
        //a rabbit can have Blue, Red or Black eyes
        //a rabbit's fur can be white, brown, black or grey
        //it has a gender
        //has a birth date, and based on that you should be able to see how old the rabbit is
        //we also know that a rabbit is a mammal that moves, sleeps and eats certain foods

        //Rabbit rabbit = new Rabbit(new DateTime(2020, 3, 1));

        ////Console.WriteLine(rabbit.GetAge()); // it is protected by private access modifier
        //Console.WriteLine(rabbit.Age);

        //Rabbit bocanila = new Rabbit(new DateTime(2018, 3, 1));
        //Console.WriteLine(bocanila.Age);

        //bocanila.Moves();

        //Rabbit myRabbit = new Rabbit();
        //myRabbit.EyeColor = EyeColor.Blue;

        //Rabbit bambi = new Rabbit
        //{
        //    BirthDate = new DateTime(2023, 1, 1),
        //    EyeColor = EyeColor.Red,
        //    FurColor = FurColor.White,
        //    Gender = Gender.Female
        //};

        //Console.WriteLine(bambi.Age);

        string date = "5/10/2023";
        DateTime productionDate = DateTime.Parse(date);
        Product myProduct = new Product(productionDate, Category.Alchool);

        Console.WriteLine($"Expiry date is: {myProduct.ExpirationDate}");

        Console.WriteLine(Product.counter);
        //Console.WriteLine(myProduct.counter);

        var myProd2 = new Product(productionDate, Category.Bread);
        var myProd3 = new Product(productionDate, Category.Alchool);

        Console.WriteLine(Product.counter);

       // myProd2.BuyBread();
    }
}

public class Rabbit // define the class
{
    // field
    private DateTime birthDate;

    //contructors
    public Rabbit()
    {
    }

    public Rabbit(DateTime birthDate)
    {
        this.birthDate = birthDate;
    }

    // properties
    public EyeColor EyeColor { get; set; }
    public FurColor FurColor { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }

    //public int Age
    //{
    //    get { return age; }
    //    private set { age = GetAge(); }
    //}

    public int Age => GetAge();

    // actions are methods, expressed by verbs
    public void Moves()
    {
        Console.WriteLine("I am a rabbit and I move");
    }

    public void Sleeps()
    {
        Console.WriteLine("I am a rabbit and I sleep");
    }

    public void Eats()
    {
        Console.WriteLine("I am a rabbit and I eat");
    }

    private int GetAge()
    {
        // subtract the age from birthdate
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthDate.Year;

        return age;
    }
}

public enum FurColor
{
    White,
    Brown,
    Black,
    Grey
}

public enum Gender
{
    Male,
    Female
}