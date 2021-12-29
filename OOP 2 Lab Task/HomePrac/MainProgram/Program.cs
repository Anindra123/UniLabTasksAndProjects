using System;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] {"Baishakh", "Joistho", "Ashar", "Shrabon", "Vadro", "Asshin",
"Kartik", "Oghraiyon", "Etc.."};

            foreach (string i in month)
            {
                if (i == "Ashar")
                {
                    Console.WriteLine("Found");
                    break;
                }


                // Console.Write(i);
                //Console.Write(" ");
            }
            Console.WriteLine("Not Found");


            Console.ReadKey();
        }
    }
}
