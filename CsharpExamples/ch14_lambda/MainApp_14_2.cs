using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class MainApp_14_2
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            // 람다식을 만드는 익명메소드는 무명 함수(Anonymous Function)라고 부름
            // 매개변수 목록 => 식 (=>은 입력 연산자)
            // C# 컴파일러의 "형식 유추"기능이 델리게이트의 선언코드로부터 매개변수 a,b의 형식을 유추하므로 생략 가능
            Calculate calc = (a, b) => a + b;

            Console.WriteLine("{0} + {1} = {2}", 3, 4, calc(3,4));
        }
    }
}
