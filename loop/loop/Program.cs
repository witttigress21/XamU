using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 10; counter++)
            {
                Console.WriteLine("Counter is {0}", counter);
                if ((counter % 5) ==0)
                    break;
             }
            
            Console.Read();
        }
    }
}
