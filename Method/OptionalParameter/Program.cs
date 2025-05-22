using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void PrintProfile(string name, string phone ="")
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("짱구");
            PrintProfile("철수", "010-123-1234");
            PrintProfile(name : "유리");
            PrintProfile(name : "맹구", phone:"010-789-7890");
        }
    }
}
