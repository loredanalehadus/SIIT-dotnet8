// See https://aka.ms/new-console-template for more information
using ClassesExplained;

Console.WriteLine("Hello, World!");


Human human1 = new Human(); // a simple, instance class, I instantiated the class
human1.Name = "Loredana";

Human human2 = new Human();
human2.Name = "Ionel";

//Util util = new Util(); //static classes cannot be instantiated
Util.Add(1, 2);
Util.CircleRadius(2);