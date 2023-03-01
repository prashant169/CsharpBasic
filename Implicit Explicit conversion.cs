using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            float b = a;       //Implicit conversion
            Console.WriteLine(b); 

            float c = 22.345f;
            int d = Convert.ToInt32 (c) ;   //Explicit conversion. Convert.ToInt32(c)
            Console.WriteLine(d);

            string e = "50";
            string f = "-60";

            int g= Convert.ToInt32 (e) + Convert.ToInt32(f) ;
            Console.WriteLine(g); 
            Console.ReadLine();
        }
    }
}
