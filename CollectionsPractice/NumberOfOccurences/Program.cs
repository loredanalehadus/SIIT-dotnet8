
//Write a program in C# that finds in a given array of integers (in the range [0…1000])
//how many times each of them occurs.
//Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}
//2-- > 2 times
//3 --> 4 times
//4-->  3 times

int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

//OccurencesWithLists(array);
OccurencesWithDictionary(array);

static void OccurencesWithLists(int[] array)
{
    List<int> numbers = new List<int>();
    List<int> occurences = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        int value = array[i];
        if (!numbers.Contains(value))
        {
            numbers.Add(value);
            occurences.Add(1);
        }
        else
        {
            var index = numbers.IndexOf(value);
            occurences[index]++;
        }
    }

    //print the result  
    //foreach(int number in numbers)
    //{
    //    var index = numbers.IndexOf(number);
    //    Console.WriteLine($"{number} => {occurences[index]} times");
    //}

    for (int index = 0; index < numbers.Count; index++)
    {
        Console.WriteLine($"{numbers[index]} => {occurences[index]} times");
    }
}

static void OccurencesWithDictionary(int[] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    for (int i = 0; i < array.Length; i++)
    {
        int key = array[i];
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, 1);
        }
        else
        {
            // update value in the dict
            //dict[key] = dict[key] + 1;
            dict[key]++;

            //int occurence;
            //dict.TryGetValue(key, out occurence);
        }
    }

    // Print the values
    foreach(var pair in dict)
    {
        Console.WriteLine($"{pair.Key} --> {pair.Value} times");
    }
            
}