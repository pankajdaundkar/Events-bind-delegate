using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_bind_delegate
{
    public delegate void EventHandler();
    public class Bank_event
    {
        public event EventHandler Insufficient_balance;
        public event EventHandler Low_balance;
        public event EventHandler Zero_balance;

        private int balance;

        public Bank_event()
        {
            balance = 10000;
        }

        public void Credit(int amount)
        {
            balance =+ amount;
           
        }
        public void Debit(int amount)
        {
            if (balance < amount)
            {
                Insufficient_balance();
            }
            else if (balance > amount)

            {
                balance = balance - amount;

                if (balance == 0)
                {
                    Zero_balance();
                }
                else if (balance < 3000)
                {
                    Low_balance();
                }

            }
            
        }
        public override string ToString()
        {
           return$"{balance}";
        }

    }
}
