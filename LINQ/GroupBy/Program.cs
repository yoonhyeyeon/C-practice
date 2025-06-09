using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
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
                new Profile(){ Name = "보라돌이", Height = 186},
                new Profile(){ Name = "뚜비", Height = 158},
                new Profile(){ Name = "나나", Height = 172},
                new Profile(){ Name = "뽀", Height = 178},
                new Profile(){ Name = "햇님", Height = 171}
            };
            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"-175cm 미만? : {Group.GroupKey}");
                foreach(var profile in Group.Profiles){
                    Console.WriteLine($">>> {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
