using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "a.json";
            using (Stream ws = new FileStream(fileName, FileMode.Create))
            {
                NameCard nc = new NameCard()
                {
                    Name = "뚜뚜",
                    Phone = "010-1234-4567",
                    Age = 12
                };
                string jsonString = JsonSerializer.Serialize<NameCard>(nc);
                byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonBytes);

                NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

                Console.WriteLine($"Name : {nc2.Name}");
                Console.WriteLine($"Phone : {nc2.Phone}");
                Console.WriteLine($"Age : {nc2.Age}");

            }
        }
    }
}
