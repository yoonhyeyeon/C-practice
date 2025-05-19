using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author","Title");
            WriteLine(fmt, "Marvel", "Stan Lee","Iron Man");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
            WriteLine(fmt, "It", "Hyeyeon", "C# Practice");

        }
    }
}
