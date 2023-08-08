using Lambda;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // out variable example
        int val1;
        int val2;
        int result = GetSomethingOut(out val1, out val2);

        int parsedResult;
        var succeded = int.TryParse("3", out parsedResult);

        if (succeded)
        {
            Console.WriteLine("Parse was succesful");
        }

        // ref example
        int val3 = 1;
        var returned = PassByRef(ref val3);

        Point myPoint = new Point { X = 1, Y = 3 };
        var point = new { X = 4, Y = 10 };

        Console.WriteLine(point);

        var car = new
        {
            Color = "red",
            Speed = 124,
            Make = new
            {
                Name = "Mazda",
                Year = 2023
            },
            Owner = new
            {
                FirstName = "Vasile",
                LastName = "Popescu",
                Address = new
                {
                    Zipcode = "121232",
                    Street = "Ciocarliei",
                    City = "Iasi"
                }
            }
        };

        Console.WriteLine(car.Color);
        Console.WriteLine(car.Make.Name);
        Console.WriteLine(car.Owner.Address.City);

        var worldCup = new[]
        {
            new {
                TeamName = "Romania",
                Players = new string[]{"Hagi", "Gigel"}
            },
            new
            {
                TeamName = "Italia",
                Players = new string[]{"Leonardo", "sdsdsadsa"}
            }
        };

        Console.WriteLine(worldCup[0].TeamName); //Romania
        Console.WriteLine(worldCup[1].TeamName); //Italia

        //Lambda
        Console.WriteLine();
        Console.WriteLine("Lambda");


        // Lambda expression
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        int noOfOdds = numbers.Count(n => n % 2 == 1); // lambda expression is (n => n % 2 == 1)

        Console.WriteLine($"No of odds using Count(): {noOfOdds}");

        // equivalent
        int numberOfOdds = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 1)
            {
                numberOfOdds++;
            }
        }

        Console.WriteLine($"No of odds using the old fashion way: {numberOfOdds}");

        var sum = numbers.Sum();
        var sum2 = Operations.Sum(numbers);

        // filter even number

        List<int> evenNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        //equivalent
        var evenNo = numbers.ToList().FindAll(number => number % 2 == 0);

        Console.WriteLine("Even numbers are:");
        //output: { 0, 2, 4, 6 }
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("{ ");

        foreach (int no in evenNo)
        {
            stringBuilder.AppendJoin(",", no);
        }

        stringBuilder.Append(" }");

        Console.WriteLine(stringBuilder.ToString());

        var divideBy5 = numbers.Where(n => n % 5 == 0);

        foreach (int number in divideBy5)
        {
            Console.WriteLine(number);
        }

        // sorting
        var ordered = numbers.OrderBy(x => x);
        var desc = numbers.OrderByDescending(x => x);

        // using lambdas and anonymous types
        var players = new List<Player>
        {
            new Player {Name = "Alex", Score = 100},
            new Player {Name = "Sofia", Score = 120},
            new Player {Name = "Mark", Score = 30},
            new Player {Name = "Lucy", Score = 50},
            new Player {Name = "Luke", Score = 90}
        };

        var sumScore = players.Sum(player => player.Score);
        Console.Write($"Total players' score is {sumScore}");

        var teamAndScores = players.Select(player => new
        {
            Echipa = player.Name,
            Punctaj = player.Score * 3
        });

        foreach (var item in teamAndScores)
        {
            Console.WriteLine($"Team name is:{item.Echipa}, punctaj: {item.Punctaj}");
        }

        var lowerThan100 = players.Where(p => p.Score < 100);
        var scoreOfLPlayer = players
            .Where(p => p.Name.StartsWith("L"))
            .Select(p => p.Score)
            .Sum();

        var startsWithL = players.Where(p => p.Name.StartsWith("L"));
        var score = startsWithL.Select(p => p.Score);
        var scoreSum = score.Sum();

        Console.WriteLine(scoreOfLPlayer);
        Console.WriteLine(scoreSum);

        string helloSummer = "Hello summer! Inca un pic si pleaca.";
        Console.WriteLine(helloSummer.WordCount());

        Console.WriteLine("Hello summer words count letters: " + helloSummer.LetterCount(10));

    }

    public static class Operations
    {
        //classic way
        public static int Sum(int[] numbers)
        {
            var sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    static int GetSomethingOut(out int somethingToGetOut, out int another)
    {
        somethingToGetOut = 0;
        somethingToGetOut += 30;

        another = 100;

        return 1;
    }

    static bool PassByRef(ref int myNumber)
    {
        myNumber += 100;
        return true;
    }
}
