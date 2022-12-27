using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    public class AddNumbers
    {
        public void Add(int a, int b)
        {
            int c = a+ b;
            Console.WriteLine("c = "+c);
        }
        public void Add(int a,int b, int c)
        {
            int d= a+ b+ c;
            Console.WriteLine("D = "+d);
        }
    }
}
