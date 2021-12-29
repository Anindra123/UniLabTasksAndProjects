using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account emp_acc1 = new Account(101, 200.2, "Emp");
            Account emp_acc2 = new Account(102, 500.5, "Emp");
            Account cus_acc1 = new Account(1001, 5000.5, "Cus");
            Account cus_acc2 = new Account(1002, 10000.8, "Cus");
            Console.WriteLine("*****************");
            Console.WriteLine("  For employees ");
            Console.WriteLine("*****************");
            Employee emp1 = new Employee();
            emp1.Name = "John";
            emp1.DOB = "20-JAN-1997";
            emp1.Acc = emp_acc1;
            Console.WriteLine("Employee Name : " + emp1.Name);
            Console.WriteLine("Employee DOB : " + emp1.DOB);
            emp1.Acc.displayAccDetails();
            Console.WriteLine();
            Employee emp2 = new Employee("Robin", "12-MAR-2002", emp_acc2);

            //with display method
            emp2.display();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine("  For customers ");
            Console.WriteLine("*****************");
            Customer cus1 = new Customer();
            cus1.Name = "Charlie";
            cus1.DOB = "06-MAY-1998";
            cus1.Acc = cus_acc1;
            Console.WriteLine("Customer Name : " + cus1.Name);
            Console.WriteLine("Customer DOB : " + cus1.DOB);
            cus1.Acc.displayAccDetails();
            Console.WriteLine();
            Customer cus2 = new Customer("Ted", "04-JULY-2006", cus_acc2);

            //with display method
            cus2.display();
            Console.ReadKey();
        }
    }
}
