using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Developar Bank", 10);

            Console.WriteLine("---------------------------WELCOME TO MY BANK APPLICATION------------------------------");
            bool continual = true;

            while (continual)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("         Open an account");
                Console.WriteLine("         Perform transactions on an account");
                Console.WriteLine("         Exit the application");

                Console.Write("Enter your choise: ");
                string choise1 = Console.ReadLine();

                switch (choise1)
                {
                    case "open":

                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("You have chose open account");
                        Console.WriteLine("           Which type of Account you want to open?");
                        Console.WriteLine("           Open a Savings account");
                        Console.WriteLine("           Open a Checking account");
                        Console.WriteLine("           Exit the application");

                        Console.Write("Enter your choise:");
                        string chose2 = Console.ReadLine();

                        switch (chose2)
                        {
                            case "savings":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("-----You have chose Savings Account-----");
                                Console.Write("Enter name: ");
                                string name1 = Console.ReadLine();
                                Console.Write("Enter date of birth: ");
                                string dob1 = Console.ReadLine();
                                Console.Write("Enter balance: ");
                                double balance1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter RoadNo: ");
                                string roadNo1 = Console.ReadLine();
                                Console.Write("Enter house No:");
                                string houseNo1 = Console.ReadLine();
                                Console.Write("Enter city: ");
                                string city1 = Console.ReadLine();
                                Console.Write("Enter country: ");
                                string country1 = Console.ReadLine();

                                Address address1 = new Address(roadNo1, houseNo1, city1, country1);

                                SavingAccount sa = new SavingAccount(name1, dob1, balance1, address1);

                                bank.AddAccount(sa);
                                Console.WriteLine("***********************************************");
                                break;

                            case "checking":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("-----You have chose Checking Account-----");
                                Console.Write("Enter name: ");
                                string name2 = Console.ReadLine();
                                Console.Write("Enter date of birth: ");
                                string dob2 = Console.ReadLine();
                                Console.Write("Enter balance: ");
                                double balance2 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter RoadNo: ");
                                string roadNo2 = Console.ReadLine();
                                Console.Write("Enter house No:");
                                string houseNo2 = Console.ReadLine();
                                Console.Write("Enter city: ");
                                string city2 = Console.ReadLine();
                                Console.Write("Enter country: ");
                                string country2 = Console.ReadLine();

                                Address address2 = new Address(roadNo2, houseNo2, city2, country2);
                                CheckingAccount ca = new CheckingAccount(name2, dob2, balance2, address2);

                                bank.AddAccount(ca);
                                Console.WriteLine("***********************************************");
                                break;

                            case "quit":
                                Console.WriteLine("******************************");
                                Console.WriteLine("quit.....");
                                Console.WriteLine("*******************************");
                                break;
                            default:
                                Console.WriteLine("********************************");
                                Console.WriteLine("Invalid option");
                                Console.WriteLine("*********************************");
                                break;
                        }
                        Console.WriteLine("---------------------------------------------------------------");
                        break;
                    case "account":
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("You have chose account");
                        Console.WriteLine("          Make a deposit");
                        Console.WriteLine("          Make a withdraw");
                        Console.WriteLine("          Make a transfer");
                        Console.WriteLine("          Change owner name");
                        Console.WriteLine("          Show the number of transactions");
                        Console.WriteLine("          Exit the application");

                        Console.Write("Enter your choise: ");
                        string choise3 = Console.ReadLine();

                        switch (choise3)
                        {
                            case "deposit":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("------Deposit------");
                                Console.Write("Enter Account Number: ");
                                int accountNomber1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter amount: ");
                                double amount1 = Convert.ToDouble(Console.ReadLine());

                                bank.Trasaction(1, accountNomber1, amount1);
                                Console.WriteLine("***********************************************");
                                break;

                            case "withdraw":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("------Withdraw-------");
                                Console.Write("Enter account Number: ");
                                int accountNomber2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter amount: ");
                                double amount2 = Convert.ToDouble(Console.ReadLine());

                                bank.Trasaction(2, accountNomber2, amount2);
                                Console.WriteLine("***********************************************");
                                break;

                            case "transfer":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("------Transfer Money-----");
                                Console.Write("Enter from  account Number: ");
                                int accountNomber3 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter transfer amount: ");
                                double amount3 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter To  account Number: ");
                                int accountNumber4 = Convert.ToInt32(Console.ReadLine());

                                bank.Trasaction(3, accountNomber3, amount3, bank.GetAccount(accountNumber4));
                                Console.WriteLine("************************************************");
                                break;

                            case "change":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("------Change Owner name------");
                                Console.Write("Enter account number: ");
                                int accountNomber5 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter new name: ");
                                string name3 = Console.ReadLine();

                                bank.Trasaction(4, accountNomber5, 0, name3);
                                Console.Write("Enter account number: ");
                                int accountNomber7 = Convert.ToInt32(Console.ReadLine());
                                bank.PrintAccountDetails(accountNomber7);
                                Console.WriteLine("***********************************************");
                                break;

                            case "show":
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("---Show number transaction---");
                                Console.Write("Enter account number: ");
                                int accountNomber6 = Convert.ToInt32(Console.ReadLine());
                                bank.Trasaction(5, accountNomber6, 0);
                                Console.WriteLine("***********************************************");

                                break;
                            case "quit":
                                Console.WriteLine("******************************");
                                Console.WriteLine("quit.....");
                                Console.WriteLine("*******************************");
                                break;

                            default:
                                Console.WriteLine("**************************************");
                                Console.WriteLine("Invalid option");
                                Console.WriteLine("***************************************");
                                break;
                        }

                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case "quit":
                        Console.WriteLine("**************************************");
                        Console.WriteLine("You have chose to exit");
                        continual = false;
                        Console.WriteLine("**************************************");
                        break;

                    default:
                        Console.WriteLine("*************************************");
                        Console.WriteLine("Invalid choise");
                        Console.WriteLine("**************************************");
                        break;
                }

            }
            Console.WriteLine("----------------------THANK YOU FOR USING MY APPLICATION-----------------------------");
        }

    }
}
