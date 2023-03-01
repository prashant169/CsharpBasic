using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNdCharDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "This is String";  //String  " "
            char b = 'C';                   //Char     ''
            Console.WriteLine(a);
            Console.WriteLine(b);


            //Escape Sequence 
            string c = "\" Welcome to C#\"";   //if we want in Double cote
            string d = "\\ Welcome to C#\\";   //if we want in Double cote 
            string e = "\t Welcome to C# ";   //if we want in 8 Or 10 Space before 
            string f = "\t One  \nTwo  \nThree \nFour";
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

          

            //Verbatim literal
            string x = @"D:\One\Two \Three";
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
