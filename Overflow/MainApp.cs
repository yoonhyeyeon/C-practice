using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {

            uint a = uint.MaxValue;     //uint의 최댓값 4294967295

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);

        }
    }
}
