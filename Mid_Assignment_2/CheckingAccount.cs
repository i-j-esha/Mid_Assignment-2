using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Assignment_2
{
    class CheckingAccount:Account
    {
        override public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Console.WriteLine(amount + " Taka Withdrawn amount");
                //this.ShowInformation();
                Console.WriteLine();
                //return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
                //return false;
            }
        }

    }
}

