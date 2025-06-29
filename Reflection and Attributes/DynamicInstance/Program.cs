﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }
        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
        }
        public string Name
        {
            get { return name; }
            set { name = value;  }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("DynamicInstance.Profile");
            MethodInfo methodInfo = type.GetMethod("Print");

            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "우후후", "512-1234");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "떙떙떙", null);
            phoneProperty.SetValue(profile, "999-5511", null);

            Console.WriteLine("{0}, {1}",
                nameProperty.GetValue(profile,null),
                phoneProperty.GetValue(profile, null));
        }
    }
}
