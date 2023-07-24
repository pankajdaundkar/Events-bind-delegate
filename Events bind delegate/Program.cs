using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_bind_delegate
{
    public class Program
    {
        static void Insufficient_balanceMessage()
        {
            Console.WriteLine(" opps ! Insufficient Balance");
        }
        static void Low_balanceMessage()
        {
            Console.WriteLine(" oops ! Low Balance");
        }
        static void Zero_Balance()
        {
            Console.WriteLine("opps ! zero balance");
        }
        static void Main(string[] args)
        {
            Bank_event bank_Event = new Bank_event();
            bank_Event.Insufficient_balance += new EventHandler(Insufficient_balanceMessage);
            bank_Event.Low_balance += new EventHandler(Low_balanceMessage);
            bank_Event.Zero_balance += new EventHandler(Zero_Balance);

            Console.WriteLine(bank_Event);

            bank_Event.Debit(400000);
            Console.WriteLine($"Debited amount is{ bank_Event}");
            bank_Event.Credit(2000);
            Console.WriteLine(bank_Event);


        }


    }
}
