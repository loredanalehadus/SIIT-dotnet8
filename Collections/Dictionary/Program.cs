// keep the student grades in a dictionary
// declare a variable 
Dictionary<string, double> studentGrades = new Dictionary<string, double>();

// populate the dictionary
studentGrades.Add("Vasile", 9.5);
studentGrades.Add("Maria", 7.25);
studentGrades.Add("Ion", 5.6);
studentGrades.Add("Greta", 9.0);

foreach (var pair in studentGrades)
{
    Console.WriteLine($"{pair.Key} --> {pair.Value}");
}

Console.WriteLine();
Console.WriteLine("Print only the keys");

foreach (var key in studentGrades.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();
Console.WriteLine("Print only the values");

foreach (var value in studentGrades.Values)
{
    Console.WriteLine(value);
}

// check if Vasile exists
if (studentGrades.ContainsKey("Vasile"))
{
    //v1. change the value of a given key
    studentGrades["Vasile"] = 8;
}

//remove an item
studentGrades.Remove("Vasile");
//v2.
double tempValue = 0;
bool vasileExists = studentGrades.TryGetValue("Vasile", out tempValue);
Console.WriteLine("Is Vasile in the dictionary? " + vasileExists);

// Keys in dict are unique; cannot add the same key twice
//studentGrades.Add("Vasile", 5);

Console.WriteLine();

foreach (var pair in studentGrades)
{
    Console.WriteLine($"{pair.Key} --> {pair.Value}");
}

Dictionary<string, int> myGrades = new Dictionary<string, int>
{
    { "Math", 9 },
    { "English", 7 }
};

///////
///Sorted Dictionary
//////

IDictionary<string, List<int>> complexDict = new SortedDictionary<string, List<int>>();

List<int> ints1 = new List<int> { 1, 3, 2, 4, 5 };
complexDict.Add("one", ints1);

List<int> ints2 = new List<int> { 6, 7, 8 };
complexDict.Add("two", ints2);

List<int> ints3 = new List<int> { 9, 10 };
complexDict.Add("first", ints3);

IDictionary<List<int>, List<int>> complicated = new Dictionary<List<int>, List<int>>();
complicated.Add(new List<int> { 1, 2 }, new List<int> { 3, 4 });


ISet<int> numbers = new SortedSet<int>();
numbers.Add(3);
numbers.Add(2);

numbers.Add(5);
numbers.Add(9);

Console.WriteLine();
Console.WriteLine("Print sorted set");

foreach (int i in numbers)
{
    Console.WriteLine(i);
}


