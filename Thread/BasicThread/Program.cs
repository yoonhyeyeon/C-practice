using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);       // 인수만큼 CPU 사용 멈춤
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            Console.WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
