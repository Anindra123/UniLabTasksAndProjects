using System;

namespace LabTask2Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Empty Constructor");
            Bivas obj1 = new Bivas();
            obj1.setName("Anindra Das Bivas");
            obj1.setID("20-41848-1");
            obj1.setCGPA(3.99);
            obj1.setSemester("Fall 21-22");
            obj1.setProgram("CSE");

            Console.WriteLine("Name :" + obj1.getName());
            Console.WriteLine("ID :" + obj1.getID());
            Console.WriteLine("CGPA :" + obj1.getCGPA());
            Console.WriteLine("Semester :" + obj1.getSemester());
            Console.WriteLine("Program :" + obj1.getProgram());

            Console.WriteLine("*******************");
            Console.WriteLine("Parameterized Constructor");
            Bivas obj2 = new Bivas("Anindra Das Bivas", "20-41848-1", 3.99, "Fall 21-22", "CSE");
            obj2.Display();
            Console.WriteLine("*******************");
            Console.WriteLine("Copy Constructor");
            Bivas obj3 = new Bivas(obj2);
            obj3.Display();
            Console.WriteLine("*******************");
            Console.WriteLine("Empty Constructor with property");
            Bivas obj4 = new Bivas();
            obj4.Name = "Anindra Das Bivas";
            Console.WriteLine("Name :" + obj4.Name);
            obj4.ID = "20-41848-1";
            Console.WriteLine("ID :" + obj4.ID);
            obj4.CGPA = 3.99;
            Console.WriteLine("CGPA :" + obj4.CGPA);
            obj4.Semester = "Fall 21-22";
            Console.WriteLine("Semester :" + obj4.Semester);
            obj4.Program = "CSE";
            Console.WriteLine("Program :" + obj4.Program);
            Console.ReadKey();
        }
    }
}
