using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Branching_and_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 34;
            const int minimumDriverAge = 16;
            
            if (myAge >= minimumDriverAge)
                Console.WriteLine("You can Drive!");
            if (myAge < minimumDriverAge)
                Console.WriteLine("You are too young to drive.");
        }
    }
}
