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
