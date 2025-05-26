﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Name: "김이박", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // 분해
            var (name, age) = b;    // (var name, var age) = b;
            Console.WriteLine($"{name}, {age}");

            // 분해2
            var (name2, age2) = ("박이김", 34);
            Console.WriteLine($"{name2}, {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
