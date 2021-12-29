using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee : Person
    {
        private string id;
        private Account acc;
        public Employee(string name, string dob, string id, Account acc) : base(name, dob)
        {
            this.id = id;
            this.acc = acc;
        }

        public void Deposit(double amount)
        {
            acc.deposit(amount);
        }
        public void Withdraw(double amount)
        {
            acc.withdraw(amount);
        }
        public override void Display()
        {
            Console.WriteLine("Employee name :" + name);
            Console.WriteLine("Employee ID :" + id);
            Console.WriteLine("Employee DOB:" + dob);
            acc.display();
        }
    }
}
