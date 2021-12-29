using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    public class Test2
    {
        public string personName;
        protected bool isAlive;
        private int age;


        //Static constructor
        static Test2()
        {
            Console.WriteLine("Static");
        }

        //Empty constructor
        //Commenting this compiler only show the parameterized constructor 
        //and copy constructor as we have written those  constructor explicitly
        //Commenting all gives default constructor
        public Test2()
        {
            Console.WriteLine("Empty");
        }

        //Constructor overloading
        //parameterized constructor
        public Test2(string personName, bool isAlive, int age)
        {
            Console.WriteLine("Parameterized");
            this.personName = personName;
            this.isAlive = isAlive;
            this.age = age;
        }

        //copy constructor
        //Constructor overloading
        public Test2(Test2 t2)
        {
            Console.WriteLine("Copy");
            this.personName = t2.personName;
            this.isAlive = t2.isAlive;
            this.age = t2.age;
        }

        public void show()
        {
            Console.WriteLine($"Fullname : {personName}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Alive status :{isAlive}");
        }
    }
}
