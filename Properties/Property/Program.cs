﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        class BirthdayInfo
        {
            private string name;
            private DateTime birthday;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public DateTime Birthday
            {
                get
                {
                    return birthday;
                }
                set
                {
                    birthday = value;
                }
            }
            public int Age
            {
                get
                {
                    return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
                }
            }
        }
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "씨샵";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
