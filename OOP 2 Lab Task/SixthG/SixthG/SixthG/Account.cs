using System;
using System.Collections.Generic;
using System.Text;

namespace SixthG
{
    class Account : IAccountOperations, IClosing
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        public void deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Wrong amount!!");
            }
            else
            { balance = balance + amount; }
        }

        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance!!");
            }
            else
            { balance = balance - amount; }
        }

        public void displayAmount()
        {
            Console.WriteLine("Balance: " + balance);
        }

        public void closeAccount()
        {
            Console.WriteLine("Account Closed");
        }

        public double getAmount()
        {
            return balance;
        }
    }
}
