using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch08_interface // DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        
        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp_8_3
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}
