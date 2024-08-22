using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q3
{
    public static void Qs3()
    {
        double balance = 1000.0;  // Initial balance
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckBalance(balance);
                    break;
                case "2":
                    balance = DepositMoney(balance);
                    break;
                case "3":
                    balance = WithdrawMoney(balance);
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CheckBalance(double balance)
    {
        Console.WriteLine("Your current balance is: Rs. " + balance);
    }

    static double DepositMoney(double balance)
    {
        Console.Write("Enter the amount to deposit: Rs. ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double depositAmount) && depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine("Rs. " + depositAmount + " has been deposited. New balance: Rs. " + balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please try again.");
        }
        return balance;
    }

    static double WithdrawMoney(double balance)
    {
        Console.Write("Enter the amount to withdraw: Rs. ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double withdrawAmount) && withdrawAmount > 0)
        {
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine("Rs. " + withdrawAmount + " has been withdrawn. New balance: Rs. " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds. Your current balance is: Rs. " + balance);
            }
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Please try again.");
        }
        return balance;
    }
}
