using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private string dateOfBirth;
        private double balance;
        private Address address;
        private int transaction = 1;
        public static int count = 1;

        public Account()
        {
            accountNumber = count;
            count++;
        }

        public Account(string accountName, string dateOfBirth, double balance, Address address) : this()
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public int Transaction
        {
            set { this.transaction = value; }
            get { return this.transaction; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }
        public void ChangeName(string name)
        {
            this.accountName = name;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {

                Console.WriteLine("perivus balance: " + this.balance + "Tk");
                Console.WriteLine("Deposit amount: " + amount);
                this.balance += amount;
                Console.WriteLine("Current balance: " + this.balance + "Tk");
                this.transaction++;
            }
            else
            {
                Console.WriteLine("Can`t deposit");

            }
        }

        virtual public void Withdraw(double amount)
        {
            balance -= amount;
            this.transaction++;
        }

        public void Transfer(Account a, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("perivus balance: " + this.balance + "Tk");
                this.balance -= amount;
                a.balance += amount;
                Console.WriteLine("Transfer from accountNo " + accountNumber + " to " + a.accountNumber + " amount " + amount + "Tk");
                Console.WriteLine("Afer transfer current account balance: " + this.balance + "Tk" + "\n");
                this.transaction++;
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
            
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder name: " + accountName);
            Console.WriteLine("Date of birth: " + dateOfBirth);
            Console.WriteLine("balance: " + balance + "Tk");
            Console.WriteLine(address.GetAddress() + Environment.NewLine);

        }
        public void Show(int accountNumber)
        {
            Console.WriteLine("From Account: "+accountNumber+ " Number of transaction occur: "+ transaction);
        }
    }
}
