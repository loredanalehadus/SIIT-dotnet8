public class Animal
{
    private string favoriteFood;
    private string name;

    public Animal(string favoriteFood, string name)
    {
        this.favoriteFood = favoriteFood;
        this.name = name;
    }

    public virtual void TellMeAboutYourself()
    {
        Console.WriteLine($"Hi, I am an animal called {name} and I love to eat {favoriteFood}");
    }
}

