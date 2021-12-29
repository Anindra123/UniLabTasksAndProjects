using System;

namespace Week2TheoryWork
{
    class Program
    {
        struct Employee
        {
            public int emp_id;
            public int salary;

            //Parameterized constructor
            public Employee(int emp_id, int salary)
            {
                this.emp_id = emp_id;
                this.salary = salary;
            }
        }
        static void Main(string[] args)
        {
            ////Implicit type conversion
            //int a = 5;
            //double b = a;
            //Console.WriteLine($"Implicit type conversion :{b}");
            ////Explicit type conversion
            //double c = 9.99;
            //int d = (int)c;
            //Console.WriteLine($"Explicit type conversion :{d}");

            //// Type casting with is and as

            //string e = "5";
            //var f = e is string;
            //Console.WriteLine(f);

            Employee emp = new Employee(2, 3000);
            Console.WriteLine(emp.salary);

            Console.ReadKey();
        }
    }
}
