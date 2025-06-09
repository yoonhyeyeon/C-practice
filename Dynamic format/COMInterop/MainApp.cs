using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleApp1
{
    class MainApp
    {
        // 옛날 방식
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }
            worksheet.SaveAs(savePath + "\\shpark-book-old.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);

            excelApp.Quit();
        }
        // 새로운 방식
        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1] = data[i, 0];
                workSheet.Cells[i + 1, 2] = data[i, 1];
            }
            workSheet.SaveAs(savePath + "\\shpart-book-dynamic.xlsx");
            excelApp.Quit();
        }

        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"파란 하늘 파란 하늘 꿈이 드리운 푸른 언덕에",   "2009" },
                {"아기 염소 여럿이 풀을 뜯고 놀아요",             "2011" },
                {"해처럼 밝은 얼굴로",                            "2013" },
                {"빗방울이 뚝뚝뚝뚝 떨어지는 날에는",             "2016" },
                {"잔뜩 찡그린 얼굴로",                            "2019" },
                {"엄마 찾아 음매 아빠 찾아 음매 울상을 짓다가",   "2018" },
                {"해가 반짝 곱게 피어나면 너무나 기다렸나 봐",    "2020" },
                {"폴짝폴짝 콩콩콩 흔들흔들 콩콩콩",               "2022" },
                {"신나는 아기 염소들",                            "2023" },
            };
            Console.WriteLine("Creating Excel document in old way...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel document in new way...");
            NewWay(array, savePath);
        }
    }
}
