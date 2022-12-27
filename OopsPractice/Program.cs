namespace OopsPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Hierarchical Inheritance
            Mammals mammals = new Mammals();
            mammals.Type();
            mammals.Dog();
            Reptiles reptiles = new Reptiles();
            reptiles.Type();
            reptiles.Crocodile();
        }
    }
}
