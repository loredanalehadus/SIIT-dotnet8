namespace OOP2
{
    public class Horse : Mammal, IMovable
    {
        public override void Digest()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine("The horse moves on its feet");
        }
    }
}
