using OOP_Practice;

public class Program
{
    public static void Main()
    {
        Dog myDog = new Dog("grey", "Grivei");
        Beagle spot = new Beagle("brown", "Spot", "my breed");

        myDog.Bark();
        myDog.Hibernate();

        //spot.Bark();
        spot.Hunt();
        spot.Hibernate();

    }
}