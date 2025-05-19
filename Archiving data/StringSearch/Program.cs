using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf() : 지정된 문자 또는 문자열 위치 찾음
            WriteLine("IndexOf 'Good' : [0}", greeting.IndexOf("Good")); ;
            WriteLine("Indexof 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf() : 지정된 문자 또는 문자열을 뒤에서부터 찾음
            WriteLine("LastIndexOf 'Good' : [0}", greeting.LastIndexOf("Good")); ;
            WriteLine("LastIndexof 'o' : {0}", greeting.LastIndexOf('o'));

            // StartWith() : 현재 문자열이 지정된 문자로 시작하는지
            WriteLine("StartWith : 'Good' : [0}", greeting.StartsWith("Good")); ;
            WriteLine("StartWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndWith() : 현재 문자열이 지정된 문자로 끝나는지
            WriteLine("EndWith : 'Good' : [0}", greeting.EndsWith("Good")); ;
            WriteLine("EndWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains() : 지정된 문자열을 포함하는지
            WriteLine("Contains : 'Evening' : [0}", greeting.Contains("Evening")); ;
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // Replace() : 다른 지정된 문자열로 모두 바뀐 새문자열을 반환
            WriteLine("Replaced 'Morning' with 'Evening' : [0}", greeting.Replace("Moning","Evening")); ;



            
           
        }
    }
}
