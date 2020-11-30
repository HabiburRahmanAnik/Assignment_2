using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Bank
    {
        private String bankName;
        private Account[] accounts;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[size];
        }

        public void AddAccount(Account account)
        {
            bool flag = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Account added");
            }
            else
            {
                Console.WriteLine("Account can`t added");
            }

        }

        public Account GetAccount(int accountNumber)
        {
            Account a = null;

            for (int i = 0; i < accounts.Length; i++)
            {

                if (accounts[i].AccountNumber == accountNumber)
                {
                    a = accounts[i];
                    break;
                }

            }
            return a;
        }

        public void Trasaction(int number, int accountNo, double amount, params dynamic[] array)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (number == 1)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        accounts[i].Deposit(amount);
                        break;
                    }
                }
                else if (number == 2)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        accounts[i].Withdraw(amount);
                        break;
                    }
                }

                else if (number == 3)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        for (int j = 0; j < array.Length; j++)
                        {
                            accounts[i].Transfer(array[j], amount);
                        }

                        break;
                    }
                }
                else if (number == 4)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        for (int j = 0; j < array.Length; j++)
                        {
                            accounts[i].ChangeName(array[j]);

                        }
                        break;
                    }
                }
                else if (number == 5)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        accounts[i].Show(accountNo);
                        break;
                    }
                }
            }

        }
        public void PrintAccountDetails(int accountNo)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i].ShowAccountInformation();
                    break;
                }
            }
        }

    }
}
