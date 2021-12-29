using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Student
    {
        private string[] s_name = new string[3];

        public string this[int i]
        {
            get { return s_name[i]; }
            set { s_name[i] = value; }
        }
    }
}
