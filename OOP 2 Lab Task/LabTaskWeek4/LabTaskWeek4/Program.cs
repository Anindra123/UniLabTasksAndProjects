using System;

namespace LabTaskWeek4
{
    class Program
    {
        //value
        static void add(int val)
        {
            val = val + 10;
            Console.WriteLine("Inside value parameter function : " + val);

        }
        //ref
        static void mul(ref int val)
        {
            val = val * 5;
            Console.WriteLine("Inside reference parameter function :" + val);

        }

        // out
        static void mul2(out int val)
        {
            val = 848;
            val = val * 1;
            Console.WriteLine("Inside out parameter function : " + val);

        }

        //params
        static void paramsFunc(params int[] vals)
        {
            Console.WriteLine("Inside params parameter function :");
            foreach (int val in vals)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        //named
        static void printSal(string personName, double sal)
        {
            Console.WriteLine("Named Parameter : ");
            Console.WriteLine(personName + " earns " + sal + " dollars ");

        }
        static void Main(string[] args)
        {
            int val = 848;
            Console.WriteLine("*****************");
            Console.WriteLine("Value Parameter");
            Console.WriteLine("*****************");
            Console.WriteLine("Before passing to function : " + val);
            add(val);
            Console.WriteLine("After passing function : " + val);
            Console.WriteLine("*****************");
            Console.WriteLine("Reference Parameter");
            Console.WriteLine("*****************");
            Console.WriteLine("Before passing to function :" + val);
            mul(ref val);
            Console.WriteLine("After passing function : " + val);
            Console.WriteLine("*****************");
            Console.WriteLine("Out Parameter");
            Console.WriteLine("*****************");
            int outval;
            mul2(out outval);
            Console.WriteLine("*****************");
            Console.WriteLine("Params Parameter");
            Console.WriteLine("*****************");
            paramsFunc(2, 0, 4, 1, 8, 4, 8, 1);
            Console.WriteLine("*****************");
            Console.WriteLine("Named Parameter");
            Console.WriteLine("*****************");
            printSal(sal: 1000, personName: "John");
            Console.WriteLine("*****************");
            Console.WriteLine("Jagged Array");
            Console.WriteLine("*****************");
            char[][] charArray = { new char[] { 'A', 'B', 'C' }, new char[] { 'D', 'E' } };
            Console.WriteLine("Before Modifying....");
            Console.WriteLine("arr[" + 0 + "][" + 2 + "]:" + charArray[0][2]);
            charArray[0][2] = 'F';
            charArray[1][1] = 'G';
            Console.WriteLine("After Modifying....");
            Console.WriteLine("arr[" + 0 + "][" + 2 + "]:" + charArray[0][2]);
            Console.WriteLine("arr[" + 1 + "][" + 1 + "]:" + charArray[1][1]);

            Console.ReadKey();
        }
    }
}
