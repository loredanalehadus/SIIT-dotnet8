public class Program
{
    public static void Main()
    {
        Animal animal = new Animal("pizza", "azorel");
        animal.TellMeAboutYourself();

        Cat cat = new Cat("Purina", "Suzy");
        cat.TellMeAboutYourself();

        // GrassFeedAnimal ga = new GrassFeedAnimal(); // cannot be instantied
        Cow cow = new Cow();
        cow.EatGrass();
        cow.DigestGrass();
    }
}
