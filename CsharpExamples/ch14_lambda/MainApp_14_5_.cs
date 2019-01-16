using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // 람다식을 이용한 식트리
{
    class MainApp_14_5_
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression =
                (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            // x=7, y=8
            Console.WriteLine("1*2+({0}-{1}) = {2}",7,8,func(7,8));
        }
    }
}
