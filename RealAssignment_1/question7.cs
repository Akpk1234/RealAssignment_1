using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q7
{
    public static void Qs7()
    {
        const int totalDays = 5;
        bool[] attendance = new bool[totalDays];

        // Record attendance for 5 days
        for (int i = 0; i < totalDays; i++)
        {
            Console.Write($"Enter attendance for day {i + 1} (P for Present, A for Absent): ");
            string input = Console.ReadLine().ToUpper();

            if (input == "P")
            {
                attendance[i] = true;
            }
            else if (input == "A")
            {
                attendance[i] = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'P' for Present or 'A' for Absent.");
                i--; // Repeat the iteration for valid input
            }
        }

        // Calculate the total number of days attended
        int daysAttended = 0;
        foreach (bool isPresent in attendance)
        {
            if (isPresent)
            {
                daysAttended++;
            }
        }

        // Identify if the student has perfect attendance
        bool perfectAttendance = (daysAttended == totalDays);

        // Display the results
        Console.WriteLine($"\nTotal number of days attended: {daysAttended}");
        if (perfectAttendance)
        {
            Console.WriteLine("The student has perfect attendance.");
        }
        else
        {
            Console.WriteLine("The student does not have perfect attendance.");
        }
    }
}
