using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.AccID = "1121";
            a1.UserName = "Bob";
            Account a2 = new Account();
            a2.AccID = "1200";
            a2.UserName = "Joe";
            Account a3 = new Account();
            a3.AccID = "1001";
            a3.UserName = "Sue";
            Account a4 = new Account();
            a4.AccID = "1500";
            a4.UserName = "Tim";
            Person p = new Person();
            p[0] = a1;
            p[1] = a3;
            p[2] = a2;
            p[3] = a4;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("User Name : " + p[i].UserName);
                Console.WriteLine("Account ID : " + p[i].AccID);
            }


            Account searchAcc = p["1200"];
            if (searchAcc != null)
            {

                Console.WriteLine("Found :" + searchAcc.UserName);
            }
            else
            {
                Console.WriteLine("User Not found");
            }



            ITruck truck = new Vehicles();
            truck.Accelarate();
            ICar car = new Vehicles();
            car.Accelarate();
            Console.ReadKey();
        }
    }
}
