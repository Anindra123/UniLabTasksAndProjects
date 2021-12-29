using System;

namespace SampleProject
{
    class Test : Test2
    {
        public string name;
        private string id;
        private double accountBalance;

        public void setName(string name)
        {
            this.name = name;   // this keyword used to differentiate between local and instance variable
        }
        public void setID(string id)
        {
            this.id = id;
        }
        public void setBalance(double accountBalance)
        {
            this.accountBalance = accountBalance;
        }
        public void setAlive(bool isAlive)
        {
            this.isAlive = isAlive;
        }

        public string getName()
        {
            return this.name;
        }
        public string getID()
        {
            return this.id;
        }
        public double getBalance()
        {
            return this.accountBalance;
        }
        public void Show()
        {
            Console.WriteLine($"Username : {name}");
            Console.WriteLine($"UID : {id}");
            Console.WriteLine($"Balance : {accountBalance}");
            Console.WriteLine($"Alive status :{isAlive}");
        }
    }
}
