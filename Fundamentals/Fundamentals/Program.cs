using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int myAge = 34;
            int yourAge = 39;

            const int retirement = 65;

            int yearsToRetirementForMe = retirement - myAge;
            int yearsToRetirementForYou = retirement - yourAge;

            Console.WriteLine("How Many Years until you retire?");
            Console.WriteLine("For Me: {0}", yearsToRetirementForMe);
            Console.WriteLine("For You: {0}", yearsToRetirementForYou);
            Console.Read();


        }
    }
}
