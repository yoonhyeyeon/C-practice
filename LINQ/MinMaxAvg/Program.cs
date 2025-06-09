using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAvg
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "보라돌이", Height = 186},
                new Profile(){Name = "뚜비", Height = 158},
                new Profile(){Name = "나나", Height = 172},
                new Profile(){Name = "뽀", Height = 178},
                new Profile(){Name = "햇님", Height = 171}
            };
            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(Profile => Profile.Height),
                                 Min = g.Min(Profile => Profile.Height),
                                 Average = g.Average(Profile => Profile.Height)
                             };
            foreach ( var stat in heightStat)
            {
                Console.Write($"{stat.Group} - Count : {stat.Count}, Max : {stat.Max}, ");
                Console.WriteLine($"Min : {stat.Min}, Average : {stat.Average}");
            }
        }
    }
}
