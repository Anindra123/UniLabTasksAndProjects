using System;

namespace SixthG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a1 = new Account(550.65);
            //a1.displayAmount();
            //a1.deposit(0);
            //a1.displayAmount();
            //a1.withdraw(550.65);
            //a1.displayAmount();
            //a1.closeAccount();
            //write codes to do account operations from the user view
            Account a2 = new Account(1000.5);
            User u1 = new User("John", a2);
            u1.Deposit(200);
            u1.Display();
            u1.Withdraw(500);
            u1.Display();
            u1.CloseAccount();
            Console.ReadKey();
        }
    }
}
