using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    interface IPen
    {
        string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string text);
    }
}
