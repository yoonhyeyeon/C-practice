using System;
using System.Globalization;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 05, 19, 17, 31, 22);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");

            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));

        }

    }
}
