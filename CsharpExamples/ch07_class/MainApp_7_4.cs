using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch07_class // StaticField
{
    // static은 메소드나 필드가
    //클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자

    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp_7_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Global.Count : {0}", Global.Count);

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine("Global.Count : {0}",Global.Count);
        }
    }
}
