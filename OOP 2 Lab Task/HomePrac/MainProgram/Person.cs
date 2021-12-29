using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgram
{
    class Person
    {
        private string name;
        private static int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static int Age
        {
            get { return age; }
            set { age = value; }
        }


        public void Show()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age :" + age);
        }
    }
}
