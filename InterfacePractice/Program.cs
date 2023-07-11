using InterfacePractice;
using InterfacePractice.Interfaces;

public class Program
{
    public static void Main()
    {
        //IPet myPet = new Pet("fetch");
        //myPet.Play();

        //IPet myToy = new Toy();
        //myToy.Play();

        Dog myDog = new Dog();
        myDog.Play();
        myDog.Hunt("duck");

        Dog dog = new Dog();
        dog.Name = "Azorel";

        Animal azorel = (Animal)dog; //downcasting
        //azorel.Age = 1; //Animal doesn't contain a property called Age

        Console.WriteLine(azorel.Name); 

        //double number = 0.12214321432;
        //float floatNumber = (float)number;

        Console.WriteLine(dog.Name);
    }
}