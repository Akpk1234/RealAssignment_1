using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Q10
    {
        public static void Qs10()
        {
            const int weeksInMonth = 4;

            Console.Write("Enter hourly wage: Rs. ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of hours worked per week: ");
            double hoursPerWeek = Convert.ToDouble(Console.ReadLine());

            double monthlySalary = hourlyWage * hoursPerWeek * weeksInMonth;
            Console.WriteLine("Monthly Salary: Rs. " + monthlySalary);

        }
    }
