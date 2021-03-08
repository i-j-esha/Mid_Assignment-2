using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Assignment_2
{
    class Account
    {
            static int accountcount = 1810;
            private int accountNumber;
            private string accountName;
            private double balance;
            private double startingBalance = 0.0;
            private string address;
            private string dateOfBirth;

            public int AccNumber()
            {
                accountNumber = accountcount;
                accountcount++;
                return accountNumber;
            }

            //public Account(string accountName, double balance, Address address)
            //{
            //    //accountNumber = accountcount;
            //    //accountcount++;
            //    this.accountName = accountName;
            //    this.balance = balance;
            //    this.address = address;
            //}
            public int AccountNumber
            {

                get { return accountNumber; }
                set { accountNumber = value; }
            }
            public string AccountName
            {

                get { return this.accountName; }
                set { this.accountName = value; }
            }
            public double Balance
            {

                get { return this.balance; }
                set { this.balance = value; }
            }

            public double StartingBalance
            {

                get { return this.startingBalance; }
                // set { this.startingBalance = value; }
            }
            public string Address
            {

                get { return this.address; }
                set { this.address = value; }
            }

            public string DateOfBirth
            {

                get { return this.dateOfBirth; }
                set { this.dateOfBirth = value; }
            }

            public void Deposit(double amount)
            {
                this.Balance += amount;
                Console.WriteLine(amount + " Taka Deposit Done");

                Console.WriteLine();
            }

            virtual public void Withdraw(double amount)
            {
                if (this.Balance - amount >= 0)
                {
                    this.Balance -= amount;
                    Console.WriteLine(amount + " Taka Withdraw Done");
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

           
            public void ShowAccountInformation()
            {
                Console.WriteLine("Account No: " + this.accountNumber + "\nAccount Name: " + this.accountName + "\nAccount Balance: " + this.balance + "\nAddress: " + this.address + "\nDate of Birth: " + this.dateOfBirth);
                //Console.WriteLine("Account No:{0}\nAccount Name:{1}\nAccount Balance:{2}\nAddress:{3}\nDate Of Birth:{4}", AccNumber(), this.accountName, this.balance,this.address,this.dateOfBirth);
                //this.address.PrintAddress();
                //Console.WriteLine(this.address.GetAddress());
            }
            //public void ShowAccountInformation()
            //{
            //    Console.WriteLine("Account No:{0}\nAccount Name:{1}\nAccount Balance:{2}", this.AccountNumber, this.accountName, this.balance);
            //    //this.address.PrintAddress();
            //    Console.WriteLine(this.address.GetAddress());
            //}

        }
    }



