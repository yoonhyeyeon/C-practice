using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw =
                new BinaryWriter(
                    new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good morning");
                bw.Write(uint.MaxValue);
                bw.Write("안녕하세요");
                bw.Write(double.MaxValue);
            }
            using (BinaryReader br =
                new BinaryReader(
                    new FileStream("a.dat", FileMode.Open)))
            {
                Console.WriteLine($"File Size : {br.BaseStream.Length} bytes");
                Console.WriteLine($"{br.ReadInt32()}");
                Console.WriteLine($"{br.ReadString()}");
                Console.WriteLine($"{br.ReadUInt32()}");
                Console.WriteLine($"{br.ReadString()}");
                Console.WriteLine($"{br.ReadDouble()}");
            }
        }
    }
}
