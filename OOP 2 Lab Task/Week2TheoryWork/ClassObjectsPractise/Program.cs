using System;

namespace ClassObjectsPractise
{
    class Student
    {
        public string studentName;
        public string studentID;
        public double cgpa;

        //Empty constructor
        public Student()
        {
            Console.WriteLine("Intialized object");
            studentName = "ABC";
            studentID = "123";
        }
        //Parameterized constructor
        public Student(string studentName, string studentID, double cgpa)
        {
            //this keyword indicated the current instance or current class
            Console.WriteLine("Parameterized constructor invoked");
            this.studentID = studentID;
            this.studentName = studentName;
            this.cgpa = cgpa;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); // Default constructor invoked
            Console.WriteLine(student.studentID);
            Console.WriteLine(student.studentName);
            Console.WriteLine(student.cgpa); // Default constructor assign value to their defaults

            //Parameterized constructor helps to assign intial values to the instance varaibles
            Student newStudent = new Student("Anindra Das Bivas", "20-41848-1", 3.99);
            Console.WriteLine(newStudent.studentID);
            Console.WriteLine(newStudent.studentName);
            Console.WriteLine(newStudent.cgpa);


            Console.ReadKey();
        }
    }
}
