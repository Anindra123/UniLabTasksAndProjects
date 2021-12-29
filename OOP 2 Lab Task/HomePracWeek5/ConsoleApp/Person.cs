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

        }

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getName()
        {
            return name;
        }
        public string getDob()
        {
            return dob;
        }
        public abstract void showDetails();
    }
}
