using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Person
    {
        private Account[] account = new Account[5];

        public Account this[int i]
        {
            get { return account[i]; }
            set { account[i] = value; }
        }

        public Account this[string id]
        {
            get
            {
                for (int i = 0; i < account.Length; i++)
                {
                    if (account[i].AccID == id)
                    {
                        return account[i];
                    }
                }
                return null;
            }
        }
    }
}
