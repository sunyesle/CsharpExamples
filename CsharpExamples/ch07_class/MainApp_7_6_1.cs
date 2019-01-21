using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch07_class // This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class MainApp_7_6_1
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine("{0} {1}", pooh.GetName(), pooh.GetPosition());

            Employee trigger = new Employee();
            trigger.SetName("Trigger");
            trigger.SetPosition("Cleaner");
            Console.WriteLine("{0} {1}", trigger.GetName(), trigger.GetPosition());
        }
    }
}
