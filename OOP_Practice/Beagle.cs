namespace OOP_Practice
{
    //derived class, child class
    internal class Beagle : Wolf // se citeste: Beagle extends Dog
    {
        public string Breed { get; set; }

        public Beagle(string furColor, string name, string breed) : base(furColor)
        {
            Breed = breed;
        }

        //new behaviour
        public void Hunt()
        {
            Console.WriteLine("Beagle is a good hunter");
        }
    }
}
