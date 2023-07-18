using OOP2;

public class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Sleep();

        dog.Sleep(1000); // method that was overriden from the inherited class

        //Animal animal  = new Animal(); // nu poate avea instanta
        Cat cat = new Cat();
        cat.Eat();
        cat.Sleep(5000);

        //IMovable horse = new IMovable(); // nu pot instantia o interfata
        IMovable horse = new Horse();
        horse.Move();
        //horse.Digest(); // reflects the interface behavior

    }

}

public abstract class Animal
{
    // cannot be overriden
    public void Sleep()
    {
        Console.WriteLine("I am an animal and I can sleep");
    }
    

    // has no implementation; method body is missing
    // MUST be overriden in the derived class
    public abstract void Sleep(int milliseconds);

    // has implementation
    public virtual void Eat()
    {
        Console.WriteLine("eat the food");
    }
}

public class Dog : Animal
{     

    public override void Sleep(int milliseconds)
    {
        Console.WriteLine($"My Dog sleeps this much: {milliseconds}.");
    }

    public void Sleep(float time)
    {
        Console.WriteLine($"Overloaded method of sleep: {time}.");
    }
}

public class Cat : Animal
{
    public override void Sleep(int milliseconds)
    {
        Console.WriteLine($"My CAT sleeps this much: {milliseconds}.");
    }

    public override void Eat()
    {
        Console.WriteLine("I like to eat my prey");
    }
}