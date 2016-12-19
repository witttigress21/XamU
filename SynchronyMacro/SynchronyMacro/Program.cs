using System;

namespace WorkMacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the date for the aml_rc (Format: DDMMMYYYY example 23JUN2016)");
            string date;
            date = Console.ReadLine();
            Console.WriteLine($"{date}");

            var month = GetMonth(date);
            var year = date.Substring(5);

            Console.WriteLine($"C:Drive\\{month} {year}\\");
            Console.ReadLine();
        }


        private string GetMonth(string date)
        {
            string formattedDate = date.Substring(2, 3);

            string xdate = string.Empty;
            switch (formattedDate)
            {
                case "JAN": return "January";
                case "FEB": return "February";
                case "MAR": return "March";
                case "APR": return "April";
                case "MAY": return "May";
                case "JUN": return "June";
                case "JUL": return "July";
                case "AUG": return "August";
                case "SEP": return "September";
                case "OCT": return "October";
                case "NOV": return "November";
                case "DEC": return "December";

                default: throw new Exception($"Unexpected input {formattedDate}, please correct");

            }
            return xdate;
        }
    }
}
