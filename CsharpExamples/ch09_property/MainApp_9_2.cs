﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples.ch09_property // Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }

    }

    class MainApp_9_2   
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}" , birth.Age);
        }   
    }
}
