using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Hello Xamarin University");

            int age = 34;
            int thisYear = DateTime.Now.Year;
            int yearBorn = thisYear - age;

            Console.WriteLine("The Year you were born is " + yearBorn);

            String name = "Jennifer";

            Console.WriteLine("My name is {0} and I am {1} years old", name, age);

            String city = "Miamisburg";

            Console.WriteLine("My name is {0} and I live in {1}.  I am {2} years old.", name, city, age);

            Console.Read();

        }
    }
}
