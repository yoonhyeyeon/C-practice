using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CallerInfo
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine(
                $"{file}(Line : {line}) {member} : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐겁다 !");
        }
    }
}
