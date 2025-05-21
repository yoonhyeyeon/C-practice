using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("종료 조건(숫자)을 입력하세요 : ");

            string input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for ( int i = 0; i < 2; i++ )
            {
                for ( int j = 0; j < 2; j++)
                {
                    for ( int k = 0; k < 3; k++)                // 반복문 2 * 2 * 3 = 12번 실행 될 수 있다.
                    {
                        if (exit_number++ == input_number)      // 조건이 참(증가 시키기전 exit_number)이면 EXIT_FOR 로 단숨에 점프
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);         // 거짓일때 실행(++ 된 채로 나옴)
                    }
                }
            }

            goto EXIT_PROGRAM;  // EXIT_FOR 만나지 않게 하기위해 EXIT_PROGRAM 으로 점프

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");

        }
    }
}
