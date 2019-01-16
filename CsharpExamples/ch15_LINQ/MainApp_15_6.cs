﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExamples    //LINQ 표준연산자 1
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; } 
    }

    class MainApp_15_6
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() {Name = "정우성", Height =186},
                new Profile() {Name = "김태희", Height =158},
                new Profile() {Name = "고현정", Height =172},
                new Profile() {Name = "이문세", Height =178},
                new Profile() {Name = "하하", Height =171}
            };

            var profiles = arrProfile
                .Where(profile => profile.Height < 175)
                .OrderBy(profile => profile.Height)
                .Select(profile =>
                new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });

            foreach (var profile in profiles)
                Console.WriteLine("{0}, {1}" , profile.Name, profile.InchHeight);
        }
    }
}