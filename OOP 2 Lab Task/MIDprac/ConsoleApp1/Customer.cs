using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    class Customer : Person
    {
        private string id;
        public Customer()
        {

        }
        public Customer(string name, string dob, string id) : base(name, dob)
        {
            this.id = id;
        }
        public Customer(Customer c) : base(c)
        {
            this.id = c.id;
        }
        static Customer()
        {
            Console.WriteLine("Static Constructor");
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Customer name :" + name);
            Console.WriteLine("Customer DOB :" + dob);
            Console.WriteLine("Customer ID:" + id);
        }
    }
}
