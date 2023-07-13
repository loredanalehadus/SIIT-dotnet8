using Encapsulation;
using Encapsulation.PeopleManagement;

public class Program
{
    public static void Main()
    {
        //Beagle beagle = new Beagle();

        //beagle.Name = "Spot"; ;
        //beagle.Bark();
        //beagle.Trick();
        //beagle.Breed = "";


        //people management app 
        Person person = new Person();
        person.Age = 23;

        Console.WriteLine($"Person's age is {person.Age}");

        Child child = new Child();
        child.Age = -76;
        Console.WriteLine($"Child's age is {child.Age}");

    }
}