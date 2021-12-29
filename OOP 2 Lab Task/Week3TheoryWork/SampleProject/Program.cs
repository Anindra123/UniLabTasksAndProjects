using System;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Test testOne = new Test();
            testOne.setName("John");
            testOne.setID("17-81848-1");
            testOne.setBalance(10000);
            testOne.name = "Clark";
            testOne.Show(); // only show two member from the class test and both members
                            // public acess modifier

            Test testTwo = new Test();
            testTwo.setName("John");
            testTwo.setID("19-41617-2");
            testTwo.setBalance(5000.5);
            testTwo.setAlive(true); // can acess the protected member from subclass
            testTwo.Show(); //gives the 8 public members among the 10 members in the class
            Console.ReadKey();

            Test2 test2 = new Test2();
            test2.personName = "Bob"; //cannot access the protected member


        }
    }
}
