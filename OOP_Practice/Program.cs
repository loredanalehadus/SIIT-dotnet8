using OOP_Practice;

public class Program
{
    public static void Main()
    {
        //Dog myDog = new Dog("grey", "Grivei");
        //Beagle spot = new Beagle("brown", "Spot", "my breed");

        //myDog.Bark();
        //myDog.Hibernate();

        ////spot.Bark();
        //spot.Hunt();
        //spot.Hibernate();


        Dog encapsDog = new Dog("white", "Ziggy");
        //encapsDog._name; // no access
        Console.WriteLine("My dog's name is " +encapsDog.Name);
        encapsDog.Bark();
        encapsDog.Name = "Spot";
        encapsDog.Show("male");
        //encapsDog.Cnp(); //inacessible;
    }
}