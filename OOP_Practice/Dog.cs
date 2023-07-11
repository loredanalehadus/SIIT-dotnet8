namespace OOP_Practice
{
    // base class, parent class
    internal class Dog : Wolf
    {
        //property
        public string Name { get; set; }

        //constructor

        public Dog(string furColor, string name) : base(furColor)
        {
            Name = name;
        }

        //public Dog(string name)
        //{
        //    Name = name;
        //}

        //method
        public void Bark()
        {
            Console.WriteLine("Ham ham");
        }

    }
}
