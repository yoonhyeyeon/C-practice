using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw =
                new StreamWriter(
                    new FileStream("a.txt", FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Good morning!");
                sw.WriteLine(uint.MaxValue);
                sw.WriteLine("안녕");
                sw.WriteLine(double.MaxValue);
            }
            using (StreamReader sr =
                new StreamReader(
                    new FileStream("a.txt", FileMode.Open)))
            {
                Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

                while(sr.EndOfStream == false)      // 스트림의 끝에 도달했는지 알려줌
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
