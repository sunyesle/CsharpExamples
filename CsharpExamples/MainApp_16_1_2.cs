using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    // 리플렉션 DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;

        public Profile()
        {
            name = ""; phone = "";
        }

        public Profile (string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine("{0}, {1}", name , phone);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }

    class MainApp_16_1_2
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("CsharpExamples.Profile"); //네임스페이스를 포함하는 전체이름을 매개 변수로
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "이지훈", "123-4567");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "신세경",null);
            phoneProperty.SetValue(profile, "000-0000",null);

            Console.WriteLine("{0}, {1}",
                nameProperty.GetValue(profile, null),
                phoneProperty.GetValue(profile, null));
        }
    }
}
