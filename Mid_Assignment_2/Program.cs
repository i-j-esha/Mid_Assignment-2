using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
                SavingsAccount save = new SavingsAccount();
                CheckingAccount check = new CheckingAccount();
                string choose, choose1, choose3;
                
                //choice = Console.ReadLine();
                int choose2, choose4, choose5;
                int savingsAccount = 0;
                int checkingAccount = 0;


                do
                {
                    Console.WriteLine("Enter 'open' for Open an account\nEnter 'account' Perform transections on an account\nEnter 'quit' for Exit the application");
                          
                    Console.WriteLine("Please enter a command\n");
                    choose = Console.ReadLine();



                    switch (choose)
                    {
                        case "open":
                            do
                            {
                                Console.WriteLine("1.Enter 'savings' for open a Savings Account\n2.Enter 'checking' for open a Checking Account\n3.Enter 'quit' for Exit the application");
                                                              
                                Console.WriteLine("Please enter a command\n");

                                choose1 = Console.ReadLine();
                                switch (choose1)
                                {
                                    case "savings account: ":
                                        Console.WriteLine("Name:");
                                        string savingName = Console.ReadLine();
                                        save.AccountName = savingName;

                                        Console.WriteLine("Date of birth:");
                                        string savingDateOfBirth = Console.ReadLine();
                                        save.DateOfBirth = savingDateOfBirth;

                                        Console.WriteLine("Address:");
                                        string savingAddress = Console.ReadLine();
                                        save.Address = savingAddress;

                                        Console.WriteLine("Starting Balance: " + save.StartingBalance);

                                        //Console.WriteLine("Account Number: " + save.AccNumber());

                                        Console.WriteLine("Now Account is created");
                                        savingsAccount = 1;
                                        break;

                                    case "checking account: ":
                                        Console.WriteLine("Name:");
                                        string checkingName = Console.ReadLine();
                                        check.AccountName = checkingName;

                                        Console.WriteLine("Date of birth:");
                                        string checkingDateOfBirth = Console.ReadLine();
                                        check.DateOfBirth = checkingDateOfBirth;

                                        Console.WriteLine("Address:");
                                        string checkingAddress = Console.ReadLine();
                                        check.Address = checkingAddress;

                                        Console.WriteLine("Starting Balance: " + check.StartingBalance);

                                        Console.WriteLine("Account Number: " + check.AccNumber());

                                        Console.WriteLine("Now Account is created");
                                        checkingAccount = 1;
                                        break;

                                }

                            } while (choose1 != "quit");
                            break;

                        case "account":
                            do
                            {
                                Console.WriteLine("Enter 'deposite' for make a deposite\nEnter 'withdraw' for Make a withdraw\nEnter 'transfer' for Make a transfer\nEnter 'show' for Show the transaction\nEnter 'quit' for Exit the application");
                
                                choose3 = Console.ReadLine();

                                switch (choose3)
                                {
                                    case "deposite":
                                        do
                                        {
                                            Console.WriteLine("Please select an option: \n1.To savings account: \nTo checking account: ");

                                            Console.WriteLine("3.Back\n");
                                            choose2 = Convert.ToInt32(Console.ReadLine());
                                            switch (choose2)
                                            {
                                                case 1:
                                                    if (savingsAccount == 1)
                                                    {
                                                        Console.WriteLine("Deposited amount of savings account:");
                                                        double savingAmount = Convert.ToDouble(Console.ReadLine());
                                                        save.Deposit(savingAmount);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("There is no savings account");
                                                    }
                                                    break;

                                                case 2:
                                                    if (checkingAccount == 1)
                                                    {
                                                        Console.WriteLine("Deposited amount of checking account:");
                                                        double checkingAmount = Convert.ToDouble(Console.ReadLine());
                                                        check.Deposit(checkingAmount);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("There is no checking account");
                                                    }
                                                    break;
                                            }
                                        } while (choose2 != 3);
                                        break;

                                    case "withdraw":
                                        do
                                        {
                                            Console.WriteLine("Please select an option:");
                                            Console.WriteLine("1.To savings account");
                                            Console.WriteLine("2.To checking account");
                                            Console.WriteLine("3.Back");
                                            choose4 = Convert.ToInt32(Console.ReadLine());
                                            switch (choose4)
                                            {
                                                case 1:
                                                    if (savingsAccount == 1)
                                                    {
                                                        Console.WriteLine("Withdrawn amount of savings account:");
                                                        double savingWithdraw = Convert.ToDouble(Console.ReadLine());
                                                        save.Withdraw(savingWithdraw);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("There is no savings account");
                                                    }
                                                    break;

                                                case 2:
                                                    if (checkingAccount == 1)
                                                    {
                                                        Console.WriteLine("Withdrawn amount of checking account:");
                                                        double checkingWithdraw = Convert.ToDouble(Console.ReadLine());
                                                        check.Withdraw(checkingWithdraw);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("There is no checking account");
                                                    }
                                                    break;
                                            }
                                        } while (choose4 != 3);
                                        break;

                                   

                                    case "show":
                                        do
                                        {
                                            Console.WriteLine("Select an option:");
                                            Console.WriteLine("1.The saving account information");
                                            Console.WriteLine("2.The checking account information");
                                            Console.WriteLine("3.Back");
                                            choose5 = Convert.ToInt32(Console.ReadLine());
                                            switch (choose5)
                                            {
                                                case 1:

                                                    save.ShowAccountInformation();

                                                break;

                                                case 2:

                                                    check.ShowAccountInformation();
                                                    break;
                                            }
                                        } while (choose5 != 3);
                                        break;

                                }

                            } while (choose3 != "quit");

                            break;

                    }


                } while (choose != "quit");


            }
        }
    }


    

