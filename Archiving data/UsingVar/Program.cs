using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;                 // var 로 선언하는 변수는 반드시 초기화해야 함.
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine("Type: {0}, Value: ", d.GetType());
            foreach (var e in d)
                Console.Write("{0}", e);

                Console.WriteLine();
           
        }
    }
}
