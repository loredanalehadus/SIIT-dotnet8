namespace Encapsulation.PeopleManagement
{
    public class Person
    {
        private int _age;

        public string Name { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                _age = value;
            }
        }
    }
}