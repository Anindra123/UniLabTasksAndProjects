using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Person
    {
        protected string name;
        protected string dob;

        public Person()
        {

        }
        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }
        public Person(Person p)
        {
            this.name = p.name;
            this.dob = p.dob;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public abstract void Display();
    }
}
