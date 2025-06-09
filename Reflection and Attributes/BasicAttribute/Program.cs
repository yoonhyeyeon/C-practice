using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAttribute
{
    class MyCalss
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm Old");
        }
        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCalss obj = new MyCalss();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
