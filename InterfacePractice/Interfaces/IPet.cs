namespace InterfacePractice.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
    }

    public interface IPet /*: IAnimal*/
    {
        // string Trick { get; set; }
        void Play();
    }

    public class Cat : IPet
    {
        public string Name => throw new NotImplementedException();

        public void Play()
        {
            throw new NotImplementedException();
        }
    }

}
