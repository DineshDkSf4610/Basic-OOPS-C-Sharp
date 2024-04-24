using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackAccountOpening
{

    public enum Gender { Select, Male, Female, Transgender }

    /// <summary>
    /// This class used to create a Customer details
    /// </summary>
    public class CustomerDetails
    {
        //field

        private static int s_customerId = 1000;

        //property

        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int Balance { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string MailId { get; set; }

        public DateTime DOB { get; set; }

        public CustomerDetails()
        {
            CustomerName = "Enter your Name";
            Gender = Gender.Select;
        }


        public CustomerDetails(string customerName, int balance, Gender gender, long phone, string mailID, DateTime dob)
        {
            s_customerId++;
            CustomerId = "HDFC" + s_customerId;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            MailId = mailID;
            DOB = dob;
        }

        public void Deposit(int amount)
        {

            Balance += amount;
        }

        public void withdraw(int amount)
        {
            Balance -= amount;
        }

    }
}