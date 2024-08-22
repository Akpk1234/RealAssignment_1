using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q8 
{
    public static void Qs8()
    {
        const int monthsInYear = 12;
        double[] monthlyExpenses = new double[monthsInYear];
        string[] monthNames = {"January", "February", "March", "April", "May", "June",
                                   "July", "August", "September", "October", "November", "December"};

        // Get the expenses for each month
        for (int i = 0; i < monthsInYear; i++)
        {
            Console.Write($"Enter the expenses for {monthNames[i]}: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double expense) && expense >= 0)
            {
                monthlyExpenses[i] = expense;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid expense amount.");
                i--; // Repeat the iteration for valid input
            }
        }

        // Calculate total expenses
        double totalExpenses = 0;
        for (int i = 0; i < monthsInYear; i++)
        {
            totalExpenses += monthlyExpenses[i];
        }

        // Identify the month with the highest and lowest expenses
        double maxExpense = monthlyExpenses[0];
        double minExpense = monthlyExpenses[0];
        int maxExpenseMonth = 0;
        int minExpenseMonth = 0;

        for (int i = 1; i < monthsInYear; i++)
        {
            if (monthlyExpenses[i] > maxExpense)
            {
                maxExpense = monthlyExpenses[i];
                maxExpenseMonth = i;
            }
            if (monthlyExpenses[i] < minExpense)
            {
                minExpense = monthlyExpenses[i];
                minExpenseMonth = i;
            }
        }

        // Display the results
        Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses}");
        Console.WriteLine($"Month with the highest expenses: {monthNames[maxExpenseMonth]} (Rs. {maxExpense})");
        Console.WriteLine($"Month with the lowest expenses: {monthNames[minExpenseMonth]} (Rs. {minExpense})");
    }
}
