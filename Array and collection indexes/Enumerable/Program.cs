﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if ( index >= array.Length )
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        //IEnumerator 멤버
        public object Current               // 현재 위치 요소를 반환
        {
            get
            {
                return array[position];
            }
        }
        //IEnumerator 멤버
        public bool MoveNext()              // 다음 위치의 요소로 이동
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        //IEnumerator 멤버
        public void Reset()                 // 요소의 위치를 첫 요소의 '앞'으로 옮김
        {
            position = -1;
        }
        //IEnumerator 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }  
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }

    }
}
