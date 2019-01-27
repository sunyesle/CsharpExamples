using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch08_interface // AbstractClass
{
    // 추상 클래스
    // - 구현을 갖을 수 있음, 인스턴스를 만들지 못함
    // - 한정자를 갖지 않으면 모드 private로 선언됨
    // - 추상 메소드를 가질 수 있음
    // - 추상 메소드는 반드시 public,protected,internal,protected internal 한정자중 하나로 수식되어야함

    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicmethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractmehodA()");
            PrivateMethodA();
        }
    }
    class MainApp_8_5
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
