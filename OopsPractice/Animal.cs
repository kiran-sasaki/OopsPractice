using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    public class Animal
    {
        public void Type()
        {
            Console.WriteLine("Type of Animal");
        }
    }
    public class Mammals:Animal
    {
        public void Dog()
        {
            Console.WriteLine("Dog is A mammal");
        }
    }
}
