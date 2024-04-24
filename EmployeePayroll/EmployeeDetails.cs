using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace EmployeePayroll
{

    public enum WorkLocation { Select, Chennai, Salem }

    public enum Gender { Select, Male, Female };
    public class EmployeeDetails
    {

        private static int s_EmployeeId = 1000;

        public string EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string Role { get; set; }

        public WorkLocation Location { get; set; }

        public string TeamName { get; set; }

        public DateTime DOJ { get; set; }

        public int NumOfWorkingDays { get; set; }

        public int NumOfLeave { get; set; }

        public Gender Gender { get; set; }

        public int Salary { get; set; }


        public EmployeeDetails(string employeeName, string role, WorkLocation workLocation, string teamName, DateTime doj, int numOfWorkingDays, int numOfLeave, Gender gender)
        {
            s_EmployeeId++;

            EmployeeID = "SF" + s_EmployeeId;
            EmployeeName = employeeName;
            Location = workLocation;
            TeamName = teamName;
            DOJ = doj;
            NumOfWorkingDays = numOfWorkingDays;
            NumOfLeave = numOfLeave;
            Gender = gender;
        }

        public void SalaryCalculate()
        {
            int result = (NumOfWorkingDays - NumOfLeave) * 500;
            Salary = result;
        }
    }
}