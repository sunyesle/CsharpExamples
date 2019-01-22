using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch07_class // TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp_7_9
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            // is : 객체가 해당 형식에 해당되는지 검사하여 결과를 bool값으로 반환
            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            // as : 형식 변환 연산자와 같은 역할을 함
            // 형식 변환 연산자가 변환에 실패하는 경우 예외를 던지는 반면, as연산자는 객체 참조를 null로 만듬
            Cat cat = mammal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
