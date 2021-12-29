using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account : IAccountOperations
    {
        private double balance;
        private string acc_id;

        public Account(double balance, string acc_id)
        {
            this.balance = balance;
            this.acc_id = acc_id;
        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount !");
            }
        }

        public void display()
        {
            Console.WriteLine("Account ID:" + acc_id);
            Console.WriteLine("Account Balance :" + balance);
        }

        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Not Enough Balance !");
            }
            else
            {
                balance -= amount;
            }

        }
    }
}
