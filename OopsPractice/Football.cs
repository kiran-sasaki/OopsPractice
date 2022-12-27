using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice
{
    public abstract class Football
    {
        public abstract void Team();
    }
    public class Manchester : Football
    {
        public override void Team()
        {
            Console.WriteLine("Manchester has a Football Culture");
        }
    }
}
