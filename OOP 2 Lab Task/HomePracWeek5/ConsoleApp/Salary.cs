using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    sealed class Salary
    {
        private int salId;
        private double salAmount;

        public void setSalId(int salId)
        {
            this.salId = salId;
        }

        public void setSalAmount(double salAmount)
        {
            this.salAmount = salAmount;
        }

        public void display()
        {
            Console.WriteLine("Salary ID: " + salId);
            Console.WriteLine("Salary Amount: " + salAmount);
        }

    }
}
