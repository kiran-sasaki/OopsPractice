namespace OopsPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PolyMorphism
           //Method Overloading
           AddNumbers addNumbers = new AddNumbers();
            addNumbers.Add(4, 5);
            addNumbers.Add(6, 7, 8);
        }
    }
}
