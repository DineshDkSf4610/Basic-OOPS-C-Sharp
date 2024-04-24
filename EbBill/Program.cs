using System;
using System.Collections.Generic;
namespace EbBill;

class Program
{
    public static void Main(string[] args)
    {
        List<EbUserDetails> userList = new List<EbUserDetails>();
        string option = "";
        do
        {
            Console.WriteLine("Select Option: \n\t1.Registration \n\t2.Login \n\t3.Exit \n");
            Console.Write("Enter a Number : ");
            int selectMenu = int.Parse(Console.ReadLine());

            switch (selectMenu)
            {
                case 1:
                    {
                        Registration();
                        break;
                    }
                case 2:
                    {
                        Login();
                        break;
                    }
                case 3:
                    {
                        option = "no";
                        Exit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }

            if (selectMenu != 3)
            {
                Console.WriteLine("Back to Home Page ? - yes/no");
                option = Console.ReadLine();
            }
        } while (option == "yes");


        void Registration()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("    Registration Form    ");
            Console.WriteLine("*************************");

            Console.Write("Enter a User Name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter a Phone Number: ");
            long phone = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter a Mail ID: ");
            string mailID = Console.ReadLine();

            EbUserDetails user = new EbUserDetails(userName, phone, mailID);

            userList.Add(user);
            Console.WriteLine("*******************************");
            Console.WriteLine("Meter ID: " + user.MeterId);
            Console.WriteLine("Registration Successfully added");
            Console.WriteLine("*******************************");


        }

        void Login()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("         Login           ");
            Console.WriteLine("*************************");

            Console.Write("Enter a Meter ID: ");
            string meterId = Console.ReadLine();

            foreach (EbUserDetails user in userList)
            {
                if (user.MeterId == meterId)
                {
                    string option = "";
                    do
                    {
                        Console.WriteLine("Select Option : ");
                        Console.WriteLine("\t1.Calculate Amount\n\t2.User Details \n\t3.Exit");
                        Console.WriteLine("Enter a Number: ");
                        int selectMenu = int.Parse(Console.ReadLine());

                        switch (selectMenu)
                        {
                            case 1:
                                {
                                    Console.WriteLine("*************************");
                                    Console.WriteLine("    Calculate Amount     ");
                                    Console.WriteLine("*************************");
                                    Console.Write("Enter a Total Units: ");
                                    int units = int.Parse(Console.ReadLine());
                                    user.CalculateAmt(units);
                                    Console.WriteLine("Total Amount: " + user.Amount);
                                    Console.WriteLine("*************************");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("*************************");
                                    Console.WriteLine("        User Details     ");
                                    Console.WriteLine("*************************");
                                    Console.WriteLine("User Name : " + user.UserName);
                                    Console.WriteLine("Mail Id : " + user.MailId);
                                    Console.WriteLine("Total Units : " + user.Unit);
                                    Console.WriteLine("Total Amount : " + user.Amount);
                                    Console.WriteLine("*************************");
                                    break;
                                }
                            case 3:
                                {
                                    option = "no";
                                    Console.WriteLine("*************************");
                                    Console.WriteLine("Exit");
                                    Console.WriteLine("*************************");
                                    break;
                                }
                        }
                        if (selectMenu != 3)
                        {
                            Console.WriteLine("Do you want to continue ? - yes/no");
                            option = Console.ReadLine();
                        }
                    } while (option == "yes");

                }
                // else
                // {
                //     Console.WriteLine("Invalid MeterID");
                // }
            }

        }

        void Exit()
        {
            Console.WriteLine("Exit");
            Console.WriteLine("*********************");
        }
    }
}