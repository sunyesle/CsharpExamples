using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch07_class
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base
    {
        // sealed 한정자로 overriding 봉인 가능함
        // virtual로 선언된 가상 메소드를 오버라이딩한 버전의 메소드만이 가능함
        public sealed override void SealMe()
        {
        }
    }

    class WantToOverride : Derived
    {
        // overriding 봉인 됨
        public override void SealMe()
        {

        }
    }

    class MainApp_7_12
    {
        static void Main(string[] args)
        {

        }
    }
}
