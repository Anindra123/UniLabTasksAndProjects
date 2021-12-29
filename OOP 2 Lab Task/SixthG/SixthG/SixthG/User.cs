using System;
using System.Collections.Generic;
using System.Text;

namespace SixthG
{
    class User
    {
        private string name;
        private Account acc;

        public User(string name, Account acc)
        {
            this.name = name;
            this.acc = acc;
        }

        //write codes to do account operations from the user view
        public void Deposit(double amount)
        {
            acc.deposit(amount);
        }
        public void Withdraw(double amount)
        {
            acc.withdraw(amount);
        }
        public void CloseAccount()
        {
            acc.closeAccount();
        }
        public void Display()
        {
            Console.WriteLine("Name :" + name);
            acc.displayAmount();
        }
    }
}
