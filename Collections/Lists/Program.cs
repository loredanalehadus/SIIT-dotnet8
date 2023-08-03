using Collections.Lists;

public class Program
{

    public static void Main()
    {
        //declare a list
        List<string> shoppingList = new List<string>();

        // how many elements
        Console.WriteLine($"Number of elements: {shoppingList.Count}");

        //add elements
        shoppingList.Add("Milk");
        shoppingList.Add("Bread");
        shoppingList.Add("Beer");
        shoppingList.Add("Chocolate");

        Console.WriteLine($"Number of elements: {shoppingList.Count}");

        List<string> wifeShoppingList = new List<string> { "Coffee", "Shoes", "Bijuterii" };

        // union of the lists
        shoppingList.AddRange(wifeShoppingList);

        //print elements
        foreach (var item in shoppingList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("");

        //sort the list
        shoppingList.Sort();

        for (int i = 0; i < shoppingList.Count; i++)
        {
            Console.WriteLine(shoppingList[i]);
        }

        // remove an element
        shoppingList.Remove("Bijuterii");

        bool exists = shoppingList.Contains("Bijuterii");
        Console.WriteLine($"Exista bijuterii? {exists}");

        // reverse items order
        shoppingList.Reverse();

        //print elements
        foreach (var item in shoppingList)
        {
            Console.WriteLine(item);
        }

        var pers1 = new Person("Vasile", "Popescu");
        var pers2 = new Person("Ion", "Ionescu");
        var pers3 = new Person("Mihai", "Eminescu");

        List<Person> people = new List<Person>();
        people.Add(pers1);
        people.Add(pers2);
        people.Add(pers3);


        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        //people.ToArray();
        Console.WriteLine($"Vasile este la pozitia {people.IndexOf(pers1)}");
        Console.WriteLine($"La pozitia 1 avem obiectul {people[1].FirstName}");

        Console.WriteLine();

        shoppingList.Clear();
        Console.WriteLine($"Shopping list has {shoppingList.Count} items");
    }
}