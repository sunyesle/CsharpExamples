using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch09_property
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

    class MainApp_9_test1
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard()
            {
                Age = 24,
                Name = "상현"
            };

            Console.WriteLine("나이:{0}", MyCard.Age);
            Console.WriteLine("이름:{0}", MyCard.Name);
        }
    }
}
