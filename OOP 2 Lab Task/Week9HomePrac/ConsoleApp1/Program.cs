using System;

namespace ConsoleApp1
{
    public delegate void SampleDel(string msg);

    class ClassA
    {
        public void MessageA(string m)
        {
            Console.WriteLine(m + " A");
        }
    }
    class ClassB
    {
        public void MessageB(string m)
        {
            Console.WriteLine(m + " B");
        }
    }
    class ClassC
    {
        public void MessageC(string m)
        {
            Console.WriteLine(m + " C");
        }
    }
    class ClassD
    {
        public void MessageD(string m)
        {
            Console.WriteLine(m + " D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //writing like this is a hassle
            ClassA a = new ClassA();
            //SampleDel del = a.MessageA;
            //del("The method was invoked from class");
            ClassB b = new ClassB();
            //del = b.MessageB;
            //del("The method was called from class");
            ClassC c = new ClassC();
            //del = c.MessageC;
            //del("The method was executed from class");
            ClassD d = new ClassD();
            //del = d.MessageD;
            //del("We had called this method from class");

            ////only pass a single value
            //SampleDel del2 = b.MessageB;
            //del2 += a.MessageA;
            //del2 += d.MessageD;
            //del2 += c.MessageC;
            //del2 -= a.MessageA;

            //del2("This method was invoked from class");
            SampleDelMethod(a.MessageA, "Called");
            SampleDelMethod(b.MessageB, "Executed");
            SampleDelMethod(d.MessageD, "Finally Called");
            SampleDelMethod(c.MessageC, "Hello World");
            Console.ReadKey();
        }

        static void SampleDelMethod(SampleDel del, string msg)
        {
            del(msg);
        }
    }
}
