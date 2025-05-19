using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class MainApp
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK };

        static void Main(string[] args)
        {

            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

        }
    }
}

namespace Enum2
{
    class MainApp2
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK };

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine( result == DialogResult.YES);
            Console.WriteLine( result == DialogResult.NO);
            Console.WriteLine( result == DialogResult.CANCEL);
            Console.WriteLine( result == DialogResult.CONFIRM);
            Console.WriteLine( result == DialogResult.OK);
        }
    }
}