using SampleProject;
using System;

namespace AnotherSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2 test2 = new Test2(); // public can acess on this assembly
            /*Test test = new Test(); */// internal cannot acess on this assembly
            test2.personName = "Nick";
            test2.show();// Empty constructor called
            Test2 test3 = new Test2("Kite", true, 40); // parameterized constructor called 
            test3.show();
            //Static constructor only called once at the beginning
            Test2 test5 = new Test2();
            test5.personName = "Joe";
            test5.show();
            Test2 test4 = new Test2(test3);
            test4.show();
            Console.ReadKey();
        }
    }
}
