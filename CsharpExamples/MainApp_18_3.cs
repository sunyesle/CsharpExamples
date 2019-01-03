using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    class MainApp_18_3
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = 
                new BinaryWriter(
                    new FileStream("a.dat", FileMode.Create));

            bw.Write(int.MaxValue);
            bw.Write("Good morning");
            bw.Write(uint.MaxValue);
            bw.Write("안녕하세요!");
            bw.Write(double.MaxValue);

            bw.Close();

            BinaryReader br =
                new BinaryReader(
                    new FileStream("a.dat", FileMode.Open));

            Console.WriteLine("File size : {0}", br.ReadInt32());
            Console.WriteLine("File size : {0}", br.ReadString());
            Console.WriteLine("File size : {0}", br.ReadUInt32());
            Console.WriteLine("File size : {0}", br.ReadString());
            Console.WriteLine("File size : {0}", br.ReadDouble());

            br.Close();
        }
    }
}
