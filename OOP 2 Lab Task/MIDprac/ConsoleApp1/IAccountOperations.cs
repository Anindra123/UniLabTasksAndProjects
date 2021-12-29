using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAccountOperations
    {
        void deposit(double amount);
        void withdraw(double amount);
        void display();
    }
}
