using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpExamples
{
    class MainApp_18_1_1
    {
        static void Main(string[] args)
        {
            
            string directory = "C:\\";
            
            //if (args.Length < 1)
            //    directory = ".";
            //else
            //    directory = args[0];
            
            Console.WriteLine("{0} directory Info", directory);
            Console.WriteLine("-Directories :");

            // 하위 디렉토리 목록 조회
            var directories = (from dir in Directory.GetDirectories(directory)
                              let info = new DirectoryInfo(dir)
                              select new
                              {
                                  Name = info.Name,
                                  Attributes = info.Attributes
                              }).ToList();

            foreach (var d in directories)
                Console.WriteLine("{0} : {1}", d.Name, d.Attributes);

            Console.WriteLine("-File :");
            // 하위 파일 목록 조회
            var files = (from file in Directory.GetFiles(directory)
                         // let은 LINQ안에서 변수를 만듬
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         });
            foreach (var f in files)
                Console.WriteLine("{0} : {1}, {2}",
                    f.Name, f.FileSize, f.Attributes);
        }
    }
}
