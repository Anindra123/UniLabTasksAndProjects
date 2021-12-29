using System;

namespace LabTaskWeek2
{
    class Program
    {
        enum InterestRateOptions { OneMonthDeposit = 1, ThreeMonthDeposit = 3, FiveMonthDeposit = 5, SevenMonthDeposit = 7 }
        static void Main(string[] args)
        {
            Console.WriteLine("Full Name :");
            Console.WriteLine("Anindra Das Bivas");
            Console.WriteLine("ID :");
            Console.WriteLine("20-41848-1");
            Console.WriteLine();

            //Implicit type casting , from low to high , no data loss
            Console.WriteLine("Implicit type casting.....");
            char val1 = 'a';
            int val2 = val1;
            Console.WriteLine(val2);
            Console.WriteLine();

            //Explicit type casting , from high to low ,  data loss
            Console.WriteLine("Explicit type casting.....");
            double val3 = 8.9;
            int val4 = (int)val3;
            Console.WriteLine(val4);
            Console.WriteLine();

            //Constant variable, the value cannot be updated but be used to do other operation
            Console.WriteLine("Constant variable demonstration.....");
            const int minAge = 18; //minAge cannot be changed 
            int age = minAge + 5;   // but can be used to perform operations
            if (age >= minAge)
            {
                Console.WriteLine("Elibile for NID registrtion ");

            }
            else
            {
                Console.WriteLine("Not Elibile for NID registrtion ");

            }
            Console.WriteLine();

            //Enum 
            Console.WriteLine("Enum demonstration.....");
            int amount = 1000;
            double interestAmount = 0;
            InterestRateOptions depositDuration = InterestRateOptions.SevenMonthDeposit;
            switch (depositDuration)
            {
                case InterestRateOptions.OneMonthDeposit:
                    interestAmount = amount + (amount * 0.3);
                    break;
                case InterestRateOptions.ThreeMonthDeposit:
                    interestAmount = amount + (amount * 0.5);
                    break;
                case InterestRateOptions.FiveMonthDeposit:
                    interestAmount = amount + (amount * 0.7);
                    break;
                case InterestRateOptions.SevenMonthDeposit:
                    interestAmount = amount + (amount * 0.9);
                    break;
            }
            Console.WriteLine("Bank balance :");
            Console.WriteLine(amount);
            Console.WriteLine("Deposited for  :");
            Console.WriteLine((int)depositDuration + " months");
            Console.WriteLine("Interest amount :");
            Console.WriteLine(interestAmount);
            Console.ReadKey();
        }
    }
}
