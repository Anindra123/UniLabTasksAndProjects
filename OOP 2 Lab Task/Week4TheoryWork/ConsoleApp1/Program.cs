using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("Sum : " + (a + b));
        }
        // reference
        public static void PersonName(ref string name)
        {
            name = "Kanye West";
            Console.WriteLine("Greatest artist of all time :" + name);
        }

        public static void PersonName2(string name)
        {
            name = "Kanye West";
            Console.WriteLine("Greatest artist of all time :" + name);

        }
        // out 
        public static void sub(out int a, out int b)
        {
            a = 5;
            b = 10;
            b -= a;
        }
        //params
        public static void BestDondaTracks(params string[] songList)
        {
            Console.WriteLine("Best tracks in donda :");
            int num = 1;
            foreach (string song in songList)
            {
                Console.WriteLine(num + ". " + song);
                num++;
            }
        }
        //named
        public static void mul(int a, double b)
        {
            Console.WriteLine("Multiplication : " + (a * b));
        }
        static void Main(string[] args)
        {
            //// value parameter
            //add(5, 10);
            //// reference parameter 
            //string name = "Drake";
            //PersonName(ref name);
            //Console.WriteLine(name);
            //string name2 = "Soulja Boy";
            //PersonName2(name2);
            //Console.WriteLine(name2);
            ////out parameter
            //int a;
            //int b;
            //sub(out a, out b);
            //Console.WriteLine("Difference :" + b);
            ////params parameter
            //BestDondaTracks("Ok Ok Pt 2", "Pure Souls", "Hurricane", "jesus lord", "Off the Grid");
            //mul(b: 2.5, a: 5);

            //one dimensional array
            //int[] arr1 = new int[5] { 2, 3, 4 }; // defining the size we have to define that number of members else error is thrown
            int[] arr = new int[] { 1, 5, 12, 23, 10, -1 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            //two dimensional array
            int[,] twoDimArr = { {1,2},
                                 {10,20},
                                 {3,-10}};
            // To get the value of -10
            Console.WriteLine("Two dimen array value :" + twoDimArr[2, 1]);


            string[][] KanyWestDiscog =
            {
                new string[] {"TLOP","2015","9.5"},
                new string[] {"ye","2018","9"},
                new string[] {"Donda","2021","8"}
            };
            Console.WriteLine("Album Name\tYear\tPersonal Rating");
            for (int i = 0; i < KanyWestDiscog.Length; i++)
            {
                for (int j = 0; j < KanyWestDiscog[i].Length; j++)
                {
                    Console.Write(KanyWestDiscog[i][j] + "\t\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
