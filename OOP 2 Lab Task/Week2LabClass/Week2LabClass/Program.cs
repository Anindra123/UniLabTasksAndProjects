using System;

namespace Week2LabClass
{
    class Program
    {
        struct Box
        {
            public double height;
            public double width;
            public Box(double x, double y)
            {
                Console.WriteLine("Parameterized");
                height = x;
                width = y;
            }
        }
        enum Days { sun, mon, tue, wed, thu, fri, sat };
        static void Main(string[] args)
        {
            //string s1 = "tuesday";
            //var v1 = s1 is string;
            //Console.WriteLine(v1);

            //Box b1 = new Box(10.5, 11.5);
            //b1.height = 10.5;
            //b1.width = 5.5;
            //Console.WriteLine(b1.height);
            //Console.WriteLine(b1.width);

            Days d = Days.sun;
            Console.WriteLine(d);
            int a = (int)Days.wed;
            Console.WriteLine(a);

            //Days d = Days.sun;
            //switch (d)
            //{
            //    case Days.sun:
            //        Console.WriteLine("Class day");
            //        break;
            //    case Days.mon:
            //        Console.WriteLine("Class day");
            //        break;
            //    case Days.tue:
            //        Console.WriteLine("Class day");
            //        break;
            //    case Days.wed:
            //        Console.WriteLine("Class day");
            //        break;
            //    case Days.thu:
            //        Console.WriteLine("usually no class");
            //        break;
            //    case Days.fri:
            //        Console.WriteLine("holiday");
            //        break;
            //    case Days.sat:
            //        Console.WriteLine("holiday");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
