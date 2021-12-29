using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Cello : IPen
    {
        public string Color { get; set; }
        bool isOpen = false;
        public bool Open()
        {
            isOpen = true;
            Console.WriteLine("Cello is open for writing.....");
            return isOpen;
        }

        public bool Close()
        {
            isOpen = false;
            Console.WriteLine("Cello is closed currently.....");
            return isOpen;
        }

        public void Write(string text)
        {
            if (isOpen)
            {
                Console.WriteLine("Cello : " + text);
            }
        }

    }
}
