using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CheckingAccount:Account
    {
        public CheckingAccount(string accountName, string dateOfBirth, double balance, Address address) : base(accountName, dateOfBirth, balance, address)
        {

        }

        override public void Withdraw(double amount)
        {
            if(Balance>=amount)
            {
                Console.WriteLine("Perivous balance: " + Balance + "Tk");
                Console.WriteLine("withdraw amount: " + amount + "Tk");
                base.Withdraw(amount);
                Console.WriteLine("After withdraw balance is: " + Balance + "Tk");
            }
            else
            {
                Console.WriteLine("Insuficant balance");
            }

        }
    }
}
