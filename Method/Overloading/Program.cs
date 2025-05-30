﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)....");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)....");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }
        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int, double)");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));

        }
    }
}
