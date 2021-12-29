using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Employee : Person
    {
        private int id;
        private Salary sal;// association - has a

        public Employee()
        {

        }

        public Employee(string name, string dob, int id, Salary sal) : base(name, dob)
        {
            this.id = id;
            this.sal = sal;
        }

        public void setSal(Salary s1)
        {
            this.sal = s1;

        }
        public void getSal()
        {
            sal.display();
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getid()
        {
            return id;
        }

        //override
        public override void showDetails()
        {

            Console.WriteLine("Emp Name: " + name);
            Console.WriteLine("Emp ID: " + id);
            Console.WriteLine("Emp Dob: " + dob);
            sal.display();
        }
    }
}
