using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask2Week2
{
    class Bivas
    {
        private string name;
        private string id;
        private double cgpa;
        private string semester;
        private string program;

        static Bivas()
        {
            Console.WriteLine("Static Constructor");
        }

        public Bivas()
        {
            Console.WriteLine("Empty");
        }
        public Bivas(string name, string id, double cgpa, string semester, string program)
        {
            Console.WriteLine("Parameterized");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
        }

        public Bivas(Bivas bivas)
        {
            Console.WriteLine("Copy");
            this.name = bivas.name;
            this.id = bivas.id;
            this.cgpa = bivas.cgpa;
            this.semester = bivas.semester;
            this.program = bivas.program;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public double CGPA
        {
            set; get;
        }
        public string Semester
        {
            set; get;
        }
        public string Program
        {
            set; get;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setID(string id)
        {
            this.id = id;
        }

        public void setCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public void setSemester(string semester)
        {
            this.semester = semester;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }

        public string getName()
        {
            return name;
        }
        public string getID()
        {
            return id;
        }

        public double getCGPA()
        {
            return cgpa;
        }

        public string getSemester()
        {
            return semester;
        }
        public string getProgram()
        {
            return program;
        }

        public void Display()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("CGPA :" + cgpa);
            Console.WriteLine("Semester :" + semester);
            Console.WriteLine("Program :" + program);
        }
    }
}
