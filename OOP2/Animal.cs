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
