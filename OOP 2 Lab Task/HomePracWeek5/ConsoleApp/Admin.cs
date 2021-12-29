using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Admin : Person
    {
        private int id;
        private Salary sal; //association - has a

        public Admin()
        {

        }

        public Admin(string name, string dob, int id, Salary sal) : base(name, dob)
        {
            this.id = id;
            this.sal = sal;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public void setSal(Salary s1)
        {
            this.sal = s1;

        }

        public int getid()
        {
            return id;
        }

        public void getSal()
        {
            sal.display();
        }

        //override
        public override void showDetails()
        {

            Console.WriteLine("Admin Name: " + name);
            Console.WriteLine("Admin ID: " + id);
            Console.WriteLine("Admin Dob: " + dob);
            sal.display();
        }

    }
}
