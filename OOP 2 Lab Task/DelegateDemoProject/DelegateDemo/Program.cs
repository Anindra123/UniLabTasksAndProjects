using System;

namespace DelegateDemo
{
    public delegate int Calc(int a, int b);

    class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public void mul(int a, int b)
        {
            Console.WriteLine($"Multiplication : {a * b}");
        }
    }
    class Program
    {
        static void Calc2(Calc del, int a, int b, string msg)
        {
            Console.WriteLine($"{msg} : {del(a, b)}");
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc2(calculator.add, 5, 10, "Addition");
            Calc2(calculator.sub, 10, 5, "Subtraction");
            //Calc2(calculator.mul, 2, 2, "Multiplication");
            calculator.mul(2, 2);
            Console.ReadKey();
        }
    }
}
