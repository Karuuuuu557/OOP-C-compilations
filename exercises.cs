using System;

namespace mybank
{
    public class BankAccount
    {
        public String accountNumber;
        public String accountName;
        public double balance;

        // Default constructor
        public BankAccount()
        {
            accountNumber = "0000";
            accountName = "Unknown";
            balance = 0.0;
            Console.WriteLine("");
        }

        // parametized constructor
        public BankAccount(String accNum, String accName, double bal)
        {
            accountNumber = accNum;
            accountName = accName;
            balance = bal;
            Console.WriteLine("");
        }


		~BankAccount()
		{
   			 Console.WriteLine("BankAccount object (Account Number: " + accountNumber + ") is being getting trashed.");
		}

        public void displayAccount()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Initial Balance: " + balance.ToString("F2"));
            Console.WriteLine("");
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit: " + amount.ToString("F2"));
        }

        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Withdraw failed: Insufficient balance.");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Withdraw: " + amount.ToString("F2"));
            }
        }

        public double checkBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("1001", "Juan Dela Cruz", 10000.00);
            BankAccount account2 = new BankAccount("1002", "Maria Santos", 15000.00);

            Console.WriteLine("BANK ACCOUNT");
            Console.WriteLine();

            account1.displayAccount();
            account1.deposit(5000.00);
            account1.withdraw(999999);
            Console.WriteLine("Updated Balance: " + account1.checkBalance().ToString("F2"));
            Console.WriteLine();

            account2.displayAccount();
            account2.deposit(3000.00);
            account2.withdraw(1000.00);
            Console.WriteLine("Updated Balance: " + account2.checkBalance().ToString("F2"));
            Console.WriteLine("");

		
        }
	}
}
