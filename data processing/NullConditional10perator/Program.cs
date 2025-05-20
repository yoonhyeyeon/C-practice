using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional10perator
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList a = null;
            a?.Add("야구");       // a?.가 null 을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            // a가 null 이므로 Count 외에는 반환X
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();    // a는 이제 더이상 null이 아님
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

        }
    }
}
