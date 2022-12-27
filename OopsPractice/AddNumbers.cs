using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    public class AddNumbers
    {
        public virtual void Add(int a, int b)
        {
            int c = a+ b;
            Console.WriteLine("c = "+c);
        }
    }
    public class Subract : AddNumbers
    {
        public override void Add(int a, int b)
        {
            int c=a- b;
            Console.WriteLine("Sub c = "+c);
        }
    }
}
