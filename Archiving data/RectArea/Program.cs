using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("사각형의 너비를 입력하세요 : ");
            string width = Console.ReadLine();

            Console.Write("사각형의 높이를 입력하세요 : ");
            string height = Console.ReadLine();

            // 사각형의 넓이 계산

            int iWidth =  int.Parse(width);
            int iHeight = int.Parse(height);

            int rectArea = iWidth * iHeight;

            // 출력
            Console.WriteLine("사각형의 넓이 : " + rectArea);

        }
    }
}
