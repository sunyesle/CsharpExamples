using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // Func 델리게이트 (결과를 반환하는 메소드를 참조 할 때 사용)
{
    class MainApp_14_4_1
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine("func1 : {0}", func1());

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine("func2(4) : {0}",func2(4));

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine("func3(22/7) : {0}", func3(22, 7));
        }
    }
}
