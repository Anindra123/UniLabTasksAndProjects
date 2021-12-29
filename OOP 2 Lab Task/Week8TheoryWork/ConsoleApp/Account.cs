using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Account
    {
        private string accID;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string AccID
        {
            get { return accID; }
            set { accID = value; }
        }



    }
}
