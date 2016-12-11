using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string yourAge = Console.ReadLine();

            int yourAgeAsInt = int.Parse (yourAge);
            yourAgeAsInt += 1;

            Console.WriteLine("Your age is {0}", yourAgeAsInt.ToString());

            Console.Read();



        }
    }
}
