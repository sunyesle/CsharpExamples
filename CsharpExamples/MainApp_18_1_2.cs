using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpExamples    // 매개변수로 입력받은 경로에 새 디렉토리나 파일을 만듬
{
    class MainApp_18_1_2
    {
        static void OnWrongType(string type)
        {
            Console.WriteLine("{0} is wrong type", type);
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
                return;
            }

            string path = args[0];
            string type = "File";
            if (args.Length > 1)
                type = args[1];

            if(File.Exists(path)||Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongType(path);
                    return;
                }
                Console.WriteLine("Update {0} {1}", path, type);
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongType(path);
                    return;
                }

                Console.WriteLine("Create {0} {1}",path, type);
            }
        }
    }
}
