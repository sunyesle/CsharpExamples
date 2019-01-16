using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch09_property
{
    class MainApp_9_test2
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real:{0}, Imaginary:{1}", complex.Real, complex.Imaginary);
        }
    }
}
