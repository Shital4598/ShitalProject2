using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitalProject2
{
    public class Bank
    {
        public static void Main(string[] args)
        {
            string username = " ";
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            long Account_number;
            Console.WriteLine("Enter Account_number : ");
            Account_number = Convert.ToInt64(Console.ReadLine());
            BankAccount newAccount = new BankAccount(username, 10000);
        }
    }

    public class BankAccount : Bank
    {

        public string username { get; set; }

        public double Balance { get; set; }

        public BankAccount(string username, double Balance)
        {
            this.username = username;
            this.Balance = Balance;

            Console.WriteLine("\nUsername: {0} , Balance: {1}", username, Balance);
            NextMenu();
        }
        public void NextMenu()
        {
            double balance = Balance;
            Console.WriteLine("Enter \n1 for Deposit," +
                                    " \n2 for Withdrawl, " +
                                     "\n3 for Logout ");

            // string StringMenu = Console.ReadLine();
            int NextChoice = Convert.ToInt32(Console.ReadLine());
            switch (NextChoice)
            {
                case 1:
                    Deposit();
                    break;
                case 2:
                   Withdraw();
                    break;
                case 3:
                    Logout();
                    break;
                default:
                    Console.WriteLine("\nInvalid Selection!!!!!!!!!!!!!");
                    break;
            }
        }

        public double Withdraw()
        {
            Console.WriteLine("\nAvailable Balance: {0}", Balance);
            Console.WriteLine("\nHow much would you like to withdraw?: ");
            double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
            if (WithdrawAmt > 0 && WithdrawAmt <= 5000)
            {

                Balance = Balance - WithdrawAmt;
                Console.WriteLine(Balance);
            }
            else
            {
                Console.WriteLine("\n withdraw does not exist............\n");
            }
            NextMenu();
            return WithdrawAmt;
        }

        public double Deposit()
        {
            Console.WriteLine("\nAvailable Balance: {0}", Balance);
            Console.WriteLine("\nHow much would you like to deposit?: ");
            double DepositAmt = Convert.ToDouble(Console.ReadLine());
            if (DepositAmt > 0)
            {
                Balance = Balance + DepositAmt;
                Console.WriteLine("Your Current balance is :"+Balance);
            }
            else
            {
                Console.WriteLine("\n Deposit amount Doesn't Exist");
            }
            NextMenu();
            return DepositAmt;
        }

        public void Logout()
        {
            Console.WriteLine("\nGoodbye: " + username);
        }
    }

}
