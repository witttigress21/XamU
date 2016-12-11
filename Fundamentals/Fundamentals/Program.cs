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

            Console.WriteLine("Will we be able to retire soon?");
            Console.WriteLine("Years till retirement for me: {0}", yearsToRetirementForMe);
            Console.WriteLine("Years till retirement for you: {0}", yearsToRetirementForYou);
            Console.Read();


        }
    }
}
