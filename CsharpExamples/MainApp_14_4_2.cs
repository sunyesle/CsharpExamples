using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // Action 델리게이트 (결과를 반환하지 않는 메소드를 참조 할 때 사용)
{
    class MainApp_14_4_2
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine("result : {0}", result);

            Action<double, double> act3 = (x, y) =>
             {
                 double pi = x / y;
                 Console.WriteLine("Action<T1, T2>({0}, {1}) : {2}", x, y, pi);
             };
            act3(22.0, 7.0);
        }
    }
}
