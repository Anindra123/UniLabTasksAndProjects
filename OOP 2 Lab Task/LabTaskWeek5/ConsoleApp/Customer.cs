using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Customer : Person
    {
        private Account acc;
        public Customer()
        {
            Console.WriteLine("Empty constructor called at customer class");
        }
        public Customer(string name, string dob, Account acc) : base(name, dob)
        {
            Console.WriteLine("Parameterized constructor called at customer class");
            this.acc = acc;
        }
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public override void display()
        {
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Customer DOB : " + dob);
            acc.displayAccDetails();
        }
    }
}
