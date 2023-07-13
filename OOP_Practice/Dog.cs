namespace OOP_Practice
{
    // base class, parent class
    internal class Dog : Wolf
    {
        // field
        private string _name;
        
        //property
        public string Name { get; set; }
        private string Gender { get; set; }

        //constructor
        public Dog(string furColor, string name) : base(furColor)
        {
            Name = name;
        }

        //method
        public void Bark()
        {
            Console.WriteLine("Ham ham");
        }

        public void Show(string gender)
        {
            if(IsMale(gender))
            {
                Console.WriteLine("show the male trick");
            }

            if(Name == "Spot")
            {
                Console.WriteLine("roll over trick");
            }

            //
        }

        private bool IsMale(string gender)
        {
            if(gender == "male" ||  gender == "MALE")
            {
                return true;
            }

            return false;
        }

        private void Cnp()
        {
            Console.WriteLine("my secret cnp");
        }

    }
}
