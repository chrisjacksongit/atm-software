using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftware
{
    internal class ATM_Software
    {
        static void Main(string[] args)
        {
            int money = 0; // Initializes the money value
            Console.WriteLine("[ATM Software]");
            Console.WriteLine("\nSelect from the menu below:");
            Console.WriteLine("1) Deposit money");
            Console.WriteLine("2) Withdraw money");
            Console.WriteLine("3) Quit");

            Console.WriteLine("Your current balance is: $" + money);
            Console.Write("Select an option - ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("\nYou have chosen to deposit money.");
                    Console.Write("How much would you like to deposit? - ");
                    int deposit = Convert.ToInt32(Console.ReadLine());

                    int addition = money + deposit; // Adds money into the bank accoount
                    if (deposit > 0)
                    {
                        Console.WriteLine("You have successfully deposited $" + deposit + " into your bank account.");
                        Console.WriteLine("Your balance is now $" + addition + ".");
                    }

                    if (deposit <= 0)
                    {
                        Console.Write("That is an invalid integer. Please try again: ");
                        int again = Convert.ToInt32(Console.ReadLine());

                        if (again > 0)
                        {
                            Console.WriteLine("You have sucessfully deposited $" + again + " into your bank account.");
                            Console.WriteLine("Your bank balance is now $" + addition + ".");
                        }

                        while (again < 0)
                        {
                            again++;
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("\nYou have chosen to withdraw money.");
                    Console.Write("How much would you like to withdraw? - ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());

                    int deduction = money - withdraw; // Subtracts money from the bank account
                    if (withdraw > 0)
                    {
                        Console.WriteLine("You have sucessfully withdrawn $" + withdraw + " from your bank account.");
                        Console.WriteLine("Your balance is now $" + deduction + ".");
                    }

                    if (withdraw < 0)
                    {
                        Console.Write("That is an invalid integer. Please try again: ");
                        int again2 = Convert.ToInt32(Console.ReadLine());

                        if (again2 > 0)
                        {
                            Console.WriteLine("You have sucessfully withdrawn $" + again2 + " from your bank account.");
                            Console.WriteLine("Your balance is now $" + deduction + ".");
                        }

                        while (again2 < 0)
                        {
                            again2++;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("\nThank you for visiting! Have a nice day!");
                    break;
            }
        }
    }
}
