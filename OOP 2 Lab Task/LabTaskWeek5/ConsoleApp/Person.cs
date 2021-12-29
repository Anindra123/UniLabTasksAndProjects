using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    abstract class Person
    {
        protected string name;
        protected string dob;
        public Person()
        {
            Console.WriteLine("Empty constructor called at base class");
        }
        public Person(string name, string dob)
        {
            Console.WriteLine("Parameterized constructor called at base class");
            this.name = name;
            this.dob = dob;
        }
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void display();
    }
}
