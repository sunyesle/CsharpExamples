using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    delegate int MyDelegate(int a, int b);  //델리게이트 선언

    class Calculator
    {
        public int Plus(int a, int b)   //델리게이트는 인스턴스 메소드 참조가능
        {
            return a + b;
        }

        public static int Minus(int a, int b)   //정적 메소드도 참조 가능
        {
            return a - b;
        }
    }

    class MainApp_13_1
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);   //델리게이트를 메소드를 호출하듯 사용하면 참조하고있는 메소드 실행됨
            Console.WriteLine(Callback(3,4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }

        
    }
}
