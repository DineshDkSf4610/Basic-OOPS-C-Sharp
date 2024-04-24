using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBill
{
    public class EbUserDetails
    {
        private static int s_meterId = 1000;


        public string MeterId { get; set; }

        public string UserName { get; set; }

        public long Phone { get; set; }

        public string MailId { get; set; }

        public int Unit {get; set;}

        public int Amount {get; set;}


        public  EbUserDetails(string userName, long phone, string mailId){
            s_meterId++;

            MeterId = "EB" + s_meterId;
            UserName = userName;
            Phone = phone;
            MailId = mailId;

        }

        public void CalculateAmt(int units){
            Unit = units;
            Amount = Unit * 5;

        }


    }
}