using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    public class Program
    {
        public static void Main()
        {
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);

            ModuleBuilder newMoudle = newAssembly.DefineDynamicModule("Calculator");
            TypeBuilder newType = newMoudle.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",
                MethodAttributes.Public,
                typeof(int),     //반환형식
                new Type[0]);    //매개변수

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i = 2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }

            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(calculate.Invoke(sum1To100, null));
        }
    }
}
