using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            // ------------------
            int iPrintRow = 9;                      // 전체 행의 개수
            int iSpaceCount = (iPrintRow - 1) / 2;  // 초기 공백 
            int iStarCount = 1;                     // 초기 별의 개수

            for (int i = 0; i < iPrintRow; i++)
            {
                // 공백의 개수
                PrintString(iSpaceCount, "  ");

                iSpaceCount = CountCal(i, iPrintRow, iSpaceCount, -1);

                // 별의 개수
                PrintString(iStarCount, "* ");

                iStarCount = CountCal(i, iPrintRow, iStarCount, 2);

                Console.WriteLine();
            }
        }


        static void PrintString(int LoopCont, string sString)
        {
            for (int j = 0; j < LoopCont; j++)
            {
                Console.Write(sString);
            }
        }

        static int CountCal(int iNowRow, int iTotalRow, int iNowValue, int iAddValue)
        {
            if (iNowRow < (iTotalRow - 1) / 2)
            {
                return iNowValue + iAddValue;
            }
            else
            {
                return iNowValue - iAddValue;
            }
        
        }

        /* 함수 안 쓴 버전 ----------------------------------------------------
            int iPrintRow = 7;      // 초기행
            int iSpaceCount = ( iPrintRow - 1 ) / 2;    // 초기 공백 수
            int iStarCount = 1;     // 초기 별 갯수

            for (int i = 0; i < iPrintRow; i++)
            {
                // 공백 갯수
                for ( int j = 0; j < iSpaceCount; j++)
                {
                    Console.Write("  ");
                }

                if ( i < ( iPrintRow - 1 ) / 2 )        
                {
                    iSpaceCount = iSpaceCount - 1;
                }
                else
                {
                    iSpaceCount = iSpaceCount + 1;
                }

                // 별의 갯수
                for ( int j = 0; j < iStarCount; j++)
                {
                    Console.Write("* ");
                }
                if ( i < (iPrintRow - 1 ) / 2 )
                {
                    iStarCount = iStarCount + 2;
                }
                else
                {
                    iStarCount = iStarCount - 2;
                }

                Console.WriteLine();
            }

        */





       

    }
}
