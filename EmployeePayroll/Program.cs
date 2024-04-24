using System;
using System.Collections.Generic;
namespace EmployeePayroll;

class Program
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();

        string option = "";

        do
        {
            Console.WriteLine("Select option :");
            Console.WriteLine("\n\t1.Registration \n\t2.Login \n\t3.Exit");
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

            if (option != "no")
            {

                Console.WriteLine("Back to Home Page ? - yes/no");
                option = Console.ReadLine();
            }

        } while (option == "yes");






        void Registration()
        {
            Console.WriteLine("********Registration Form***********");
            Console.WriteLine("");

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Role: ");
            string role = Console.ReadLine();

            Console.Write("Select Location: \n\tChennai \n\tSalem\n");
            WorkLocation WorkLoction = Enum.Parse<WorkLocation>(Console.ReadLine());

            Console.Write("Enter Your Team Name: ");
            string teamName = Console.ReadLine();

            Console.WriteLine("Enter Your Date of Joining: dd/MM/yyyy");
            DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter a Number of Working days in Month : ");
            int numOfWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter a Number Leave Taken : ");
            int numOfLeave = int.Parse(Console.ReadLine());

            Console.Write("Select a Gender: \n\t1.Male \n\t2.Female \n\t3.Transgender\n");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());

            Console.WriteLine("----------------------------");

            EmployeeDetails employee = new EmployeeDetails(name, role, WorkLoction, teamName, doj, numOfWorkingDays, numOfLeave, gender);

            employeeList.Add(employee);

            Console.WriteLine("Employee ID :" + employee.EmployeeID);
            Console.WriteLine("Registration Successfully Added");

            Console.WriteLine("-----------------------------");

        }

        void Login()
        {

            Console.WriteLine("**********Login************");
            Console.Write("Enter Your Employee Id: ");
            string employeeId = Console.ReadLine();

            foreach (EmployeeDetails employee in employeeList)
            {
                if (employee.EmployeeID == employeeId)
                {
                    string option = "";
                    do
                    {

                        Console.WriteLine("********************");
                        Console.WriteLine("Login Successfully");
                        Console.WriteLine("********************");

                        Console.WriteLine("Select Option: Type a Number");
                        Console.WriteLine("\n\t1.Calculate Salary \n\t2.Display Details \n\t3.Exit");
                        int subMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        switch (subMenu)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Calculate Salary");
                                    Console.WriteLine("");
                                    employee.SalaryCalculate();
                                    Console.WriteLine("Salary : " + employee.Salary);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("********************");
                                    Console.WriteLine("Name : " + employee.EmployeeName);
                                    Console.WriteLine("Role : " + employee.Role);
                                    Console.WriteLine("Work Location : " + employee.Location);
                                    Console.WriteLine("Team Name : " + employee.TeamName);
                                    Console.WriteLine("Date of joining : " + employee.DOJ);
                                    Console.WriteLine("Gender : " + employee.Gender);
                                    Console.WriteLine("*********************");
                                    break;
                                }
                            case 3:
                                {
                                    option = "no";
                                    Console.WriteLine("Exit");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Input Please check");
                                    break;
                                }
                        }

                        if (option != "no")
                        {
                            Console.WriteLine("Do you want to continue ? - yes/no");
                            option = Console.ReadLine();

                        }

                    } while (option == "yes");

                    break;
                }
                else
                {
                    Console.WriteLine("User Invalid ID");
                }
            }

        }

        void Exit()
        {
            Console.WriteLine("Exit");

        }
    }
}