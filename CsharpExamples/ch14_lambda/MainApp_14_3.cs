using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // 문 형식의 람다식 (Statement Lambda)
{
    class MainApp_14_3
    {
        delegate string Concatenate(string[] args);

        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;
                    return result;
                };

            Console.WriteLine(concat(args));

            string[] array = { "아", "배고파", "밥", "먹고", "싶다." };
            Console.WriteLine(concat(array));
        }
    }
}
