using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreonArray
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34};

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);     // 배열정리
            Array.ForEach<int>(scores, new Action<int>(Print));     // 배열의 모든요소에 동일한 작업 수행하게 함
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 배열의 차원을 반환

            Console.WriteLine($"Binary Search : 81 is at" +
                $"{Array.BinarySearch<int>(scores, 81)}");  // 이진탐색을 수행
            Console.WriteLine($"Linear Search : 90 is at" +
                $"{Array.IndexOf(scores, 90)}");            // 찾고자 하는 특정 데이터를 반환
            Console.WriteLine($"Everyone passed ? : " + 
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");   // 지정한 조건에 부합하는지 반환

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : " +
                $"{ scores.GetLength(0)} ");

            Array.Resize<int>(ref scores, 10);      // 5였던 배열의 용량을 10으로 재조정
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);  // 초기화
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0 , 3);   // scores배열의 0번째부터 3개요소를 sliced 배열의 0번째~2번째 요소에 차례대로 복사
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();

        }
    }
}
