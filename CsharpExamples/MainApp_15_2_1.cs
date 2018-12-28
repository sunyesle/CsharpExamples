using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    //  LINQ
{
    class MainApp_15_2_1
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers  // from (범위 변수) in (데이터 원본)
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (var n in result)
            {
                Console.WriteLine("짝수 : {0}" , n);
            }
        }
    }
}
