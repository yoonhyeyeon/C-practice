using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "보라돌이" ,  Height= 186},
                new Profile(){Name = "뚜비" ,  Height= 158},
                new Profile(){Name = "나나" ,  Height= 172},
                new Profile(){Name = "뽀" ,  Height= 178},
                new Profile(){Name = "햇님" ,  Height= 171}
            };

            Product[] arrProduct =
            {
                new Product(){Title = "바나나", Star = "보라돌이"},
                new Product(){Title = "딸기", Star = "뚜비"},
                new Product(){Title = "키위", Star = "뚜비"},
                new Product(){Title = "사과", Star = "나나"},
                new Product(){Title = "맛있음", Star = "뽀"},
            };

            var listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine("-----내부 조인 결과 -----");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Work}, 키 : {profile.Height}cm ",
                    profile.Name, profile.Work, profile.Height);
            }
            listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps
                from product in ps.DefaultIfEmpty(new Product() { Title = " 그런거 없음" })
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };
            Console.WriteLine();
            Console.WriteLine("-----외부 조인 결과 -----");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Work}, 키 : {profile.Height}cm ");
            }
        }
    }
}
