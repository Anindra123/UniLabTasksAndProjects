using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Salary s1 = new Salary();
            s1.setSalId(1);
            s1.setSalAmount(500.55);
            Salary s2 = new Salary();
            s2.setSalId(2);
            s2.setSalAmount(300.33);
            Salary s3 = new Salary();
            s3.setSalId(3);
            s3.setSalAmount(100.1);

            Admin a1 = new Admin("Alex", "20-FEB-2001", 10, s1);
            a1.showDetails();
            Employee e1 = new Employee("John", "21-JAN-2002", 22, s2);
            e1.showDetails();
            Customer c1 = new Customer("Bob", "22-FEB-2005", 190, s3);
            c1.showDetails();


            Console.ReadKey();
        }
    }
}
