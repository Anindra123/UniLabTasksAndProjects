using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Customer : Person
    {
        private int id;
        private Salary sal; // association - has a
        public Customer()
        {

        }

        public Customer(string name, string dob, int id, Salary sal) : base(name, dob)
        {
            this.id = id;
            this.sal = sal;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getid()
        {
            return id;
        }

        //override
        public override void showDetails()
        {

            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Dob: " + dob);
            sal.display();
        }

    }
}
