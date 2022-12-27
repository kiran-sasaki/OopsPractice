namespace OopsPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Encapsulation
            Information info = new Information();
            Console.WriteLine("Enter Name");
            info.name = Console.ReadLine();
            Console.WriteLine("Enter roll Number");
            info.rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0} RollNo : {1}",info.name,info.rollNo);
        }
    }
}
