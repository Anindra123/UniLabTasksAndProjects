using System;
using System.Collections.Generic;
using System.Text;

namespace SixthG
{
    interface IAccountOperations
    // interface keyword interface_name
    {
        void deposit(double amount);
        void withdraw(double amount);
        void displayAmount();
        double getAmount();
    }
}
