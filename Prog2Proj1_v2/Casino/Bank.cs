using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Bank
    {

        public float Balance { get; set; }
        public string PaymentMethod { get; set; }
        public bool Verified { get; set; }

        //Ändra public till public float
        public float Deposit(float Balance, string PaymentMethod, bool Verified)
        {
            return Balance;
        }


    }
}
