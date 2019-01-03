using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone , int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }

        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp_18_5_2
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("박상현", "010-000-0000", 33));
            list.Add(new NameCard("이지훈", "010-123-1234", 26));
            list.Add(new NameCard("신세경", "010-111-1111", 21));

            serializer.Serialize(ws, list);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List<NameCard>)deserializer.Deserialize(rs);
            rs.Close();

            foreach(NameCard nc in list2)
            {
                Console.WriteLine(
                    "Name: {0}, Phone: {1}, Age: {2}",
                    nc.Name, nc.Phone , nc.Age);
            }
        }
    }
}
