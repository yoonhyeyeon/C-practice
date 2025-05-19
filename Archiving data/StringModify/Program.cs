using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringModify
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToLower : 대문자를 소문자로 , ToUpper : 소문자를 대문자로
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            // Insert : 삽입 , Remove : 삭제
            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, "Sunny"));
            WriteLine(" Remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

            // Trim : 앞/뒤 공백 삭제, TrimStart : 앞 공백 삭제 , TrimEnd : 뒤에 있는 공백 삭제
            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());

        }
    }
}
