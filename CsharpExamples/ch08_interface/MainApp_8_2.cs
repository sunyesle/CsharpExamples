using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch08_interface // Interface
{
    // 인터페이스
    // - 메소드, 이벤트, 인덱서, 프로퍼티만 가질수 있음, 구현부 없음
    // - 접근 제한 한정자를 사용할수 없음, 모든 것이 public으로 선언됨
    // - 인스턴스를 가질 수 없음, 이 인터페이스를 상속받는 클래스의 인스턴스를 만드는 것은 가능함

    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now .ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요. : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : "+ temperature);
            }
        }
    }

    class MainApp_8_2
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
        }
    }
}
