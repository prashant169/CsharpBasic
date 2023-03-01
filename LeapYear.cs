using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year ;
            Console.WriteLine("input a year");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine(year + "is a leap year .\n");

            else if ((year % 100) == 0)
                Console.WriteLine(year + " IS a lea[ year.\n");

            else if ((year % 4) == 0)
                Console.WriteLine(year + "is a leap year");

            else
                Console.WriteLine(year + "Is not a leap year.\n");
            Console.ReadLine();
             


        }
    }
}
