using System;
using System.Collections.Generic;
using BackAccountOpening;
namespace BankAccountOpening;

class Program
{


    public static void Main(string[] args)


    {
        List<CustomerDetails> customerDetails = new List<CustomerDetails>();

        string option = "";

        do
        {
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Please Select Ooption, Enter a Number: 1 or 2 or 3");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
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
                        Exit();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
            if (menu == 3)
            {
                option = "no";
                break;
            }
            else
            {
                Console.WriteLine("Back to Home Page ? - yes/no");
                option = Console.ReadLine();
            }



        } while (option == "yes");

        void Registration()
        {
            Console.WriteLine("Welcome To Registration");

            Console.WriteLine("Enter a Customer Name: ");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Deposit Amount: ");
            int Balance = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Your Gender: Male, Female, Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());

            Console.WriteLine("Enter Your Phone Number: ");
            long Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Mail ID : ");
            string MailId = Console.ReadLine();

            Console.WriteLine("Enter Your Date of Birth:");
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            CustomerDetails customer = new CustomerDetails(CustomerName, Balance, gender, Phone, MailId, DOB);

            customerDetails.Add(customer);
            Console.WriteLine("*************************");
            Console.WriteLine("Your Cutomer Id is ===>" + customer.CustomerId);
            Console.WriteLine("Registration Successfully");
            Console.WriteLine("*************************");

        }

        void Login()
        {
            Console.WriteLine("Welcome to Login");
            Console.WriteLine("Enter Your Customer Id: ");
            string cusId = Console.ReadLine();

            foreach (CustomerDetails customer in customerDetails)
            {
                if (customer.CustomerId == cusId)
                {
                    string option = "";
                    do
                    {
                        Console.WriteLine("**********Your Details***********");
                        Console.WriteLine("Name :" + customer.CustomerName + "\nDOB:" + customer.DOB + "\nPhone Number:" + customer.Phone);
                        Console.WriteLine("Balance: " + customer.Balance + "\nMail Id: " + customer.MailId);
                        Console.WriteLine("************  End ***************");
                        Console.WriteLine("1.Deposit \n2.withdraw \n3.balance check \n4.Exit");
                        int input = int.Parse(Console.ReadLine());

                        switch (input)
                        {
                            case 1:
                                {
                                    Deposit(customer);
                                    break;
                                }
                            case 2:
                                {
                                    withdraw(customer);
                                    break;
                                }
                            case 3:
                                {
                                    CheckBalance(customer);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Input");
                                    break;
                                }
                        }

                        Console.WriteLine("****************");
                        Console.WriteLine("Do you want to continue?- yes/no");
                        option = Console.ReadLine();
                    } while (option == "yes");



                }
                else
                {
                    Console.WriteLine("Invalid Customer Id");
                }
            }
        }



        void Exit()
        {
            Console.WriteLine("Exit");
        }

        void Deposit(CustomerDetails customer)
        {
            Console.WriteLine("Amount: ");
            int amoutn = int.Parse(Console.ReadLine());
            // customer.Balance += amoutn;
            customer.Deposit(amoutn);
            Console.WriteLine("Amount Successfully Added");
            Console.WriteLine("balance :" + customer.Balance);
        }

        void withdraw(CustomerDetails customer)
        {
            Console.WriteLine("Amount: ");
            int amoutn = int.Parse(Console.ReadLine());
            // customer.Balance -= amoutn;
            customer.withdraw(amoutn);
            Console.WriteLine("Withdraw Successfully");
            Console.WriteLine("Balance: " + customer.Balance);
        }

        void CheckBalance(CustomerDetails customer)
        {
            Console.WriteLine("Balance: " + customer.Balance);
        }
    }


}