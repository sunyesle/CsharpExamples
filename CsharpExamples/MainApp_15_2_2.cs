using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp_15_2_2
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height =186},
                new Profile() { Name = "김태희", Height = 158},
                new Profile() { Name = "고현정", Height =172},
                new Profile() { Name = "이문세", Height =178},
                new Profile() { Name = "하하", Height =171}
            };

            var profiles = from profile in arrProfile

                           // 해당조건에 부합하는 데이터만을 걸러냄
                           where profile.Height < 175

                           // 데이터를 정렬함. 정렬의 기준이될 항목을 매개변수로 입력
                           // orderby ~ ascending : 오름차순 , orderby ~ descending : 내림차순
                           // 기본적으로 오름차순으로 데이터 정렬
                           orderby profile.Height

                           // 최종결과를 추출함. 무명 형식도 사용가능
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
                Console.WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
        }
    }
}
