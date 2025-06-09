using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GetType
{
    class Program
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("----- Interfaces ------");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine("Name : {0}", i.Name);

            Console.WriteLine();
        }
        static void PrintFields(Type type)
        {
            Console.WriteLine("----- Fields -----");

            FieldInfo[] fields = type.GetField(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance);
        }
        static void Main(string[] args)
        {
        }
    }
}
