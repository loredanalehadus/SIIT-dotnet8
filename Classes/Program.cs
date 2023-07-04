using Classes;

public static class Program
{
    public static void Main()
    {
        //string name1 = "Ronaldo";
        //string country1 = "Portugal";
        //double rating1 = 100;

        //string name2 = "Hagi";
        //string country2 = "Romania";
        //double rating2 = 100;

        FootbalPlayer ronaldo = new FootbalPlayer();
        ronaldo.Name = "Ronaldo";
        ronaldo.Country = "Portugal";
        ronaldo.Rating = 100;
        ronaldo.Age = -87;
        ronaldo.MatchDay = ZileleSaptamanii.Marti;

        Console.WriteLine(ronaldo);
        Console.WriteLine($"{ronaldo.Name} " +
            $"is from {ronaldo.Country} " +
            $"with the score rating of " +
            $"{ronaldo.Rating} and is" +
            $"{ronaldo.Age} old and will play on {ronaldo.MatchDay}" +
            $"with his {(int)Level.Advanced} level");

        FootbalPlayer hagi = new FootbalPlayer("Hagi");

        Console.WriteLine($"{hagi.Name} " +
            $"is from {hagi.Country} " +
            $"with the score rating of " +
            $"{hagi.Rating} and is" +
            $"{hagi.Age} old.");


        Dog myDog = new Dog();
        myDog.Name = "Spot";
        myDog.Breed = "Sharpei";
        myDog.BirthYear = 2005;

        //Console.WriteLine(myDog.LIVING_SPAN); // cannot be neither modified or read outside the class
        //Console.WriteLine(myDog.Breed); //compile error due to restricted visibily access 

        Dog yourDog = new Dog("Grivei", "Metis", 2023);
        //yourDog.Name = "Grivei";
        //yourDog.Breed = "Metis";
        //yourDog.BirthYear = 2023;

        Console.WriteLine($"My dog's name is {myDog.Name}");
        Console.WriteLine($"Your dog's name is {yourDog.Name}");


        Dog lonelyDog = new Dog("Azorel", "Vasilica");
        Console.WriteLine(lonelyDog.NameAndOwner);


        myDog.PrintDateOfBirth();
        yourDog.PrintDateOfBirth();


    }

}

public enum ZileleSaptamanii
{
    Luni,
    Marti,
    Miercuri,
    Joi
}

enum Level
{
    Begginer = 100,
    Intermidiate = 200,
    Advanced = 300
}