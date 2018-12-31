using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // 커스텀 애트리뷰트
{
    [System.AttributeUsage(System.AttributeTargets.Class,
        AllowMultiple =true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }
    [History ("Sean", version = 0.1, changes = "2018-12-01 Created class stub")]
    [History ("Seon", version = 0.2, changes = "2018-12-31 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }
    class MainApp_16_2_3
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                    Console.WriteLine("Ver:{0}, Programmer:{1}, Changes:{2}",
                        h.version, h.GetProgrammer(), h.changes);
            }
        }
    }
}
