using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Employee : Person
    {
        private Account acc;

        public Employee()
        {
            Console.WriteLine("Empty constructor called at employee class");
        }

        public Employee(string name, string dob, Account acc) : base(name, dob)
        {
            Console.WriteLine("Parameterized constructor called at employee class");
            this.acc = acc;
        }
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }


        public override void display()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee DOB : " + dob);
            acc.displayAccDetails();
        }
    }
}
