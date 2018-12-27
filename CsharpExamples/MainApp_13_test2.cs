using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    delegate void Mydelegate(string message);

    class MyNotifier
    {
        public event Mydelegate SomethingHappened;
        public void DoSomething(int num)
        {
            if (num == 30)
                SomethingHappened(String.Format("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", num));
        }
    }

    class MainApp_13_test2
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new Mydelegate(MyHandler);

            for (int i = 0; i < 40; i++)
            {
                notifier.DoSomething(i);
            }

        }
    }
}
