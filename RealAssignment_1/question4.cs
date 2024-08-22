using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q4
{
    public static void Qs4()
    {
        double[] marks = new double[5];
        double totalMarks = 0;

        // Get the marks for five subjects
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the marks for subject {i + 1}: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double mark) && mark >= 0 && mark <= 100)
            {
                marks[i] = mark;
                totalMarks += mark;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid mark between 0 and 100.");
                i--; // Repeat the iteration for valid input
            }
        }

        // Calculate the average
        double average = totalMarks / 5;

        // Determine the grade
        char grade;
        if (average >= 90)
        {
            grade = 'A';
        }
        else if (average >= 80)
        {
            grade = 'B';
        }
        else if (average >= 70)
        {
            grade = 'C';
        }
        else if (average >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // Display the average and grade
        Console.WriteLine($"The average mark is: {average}");
        Console.WriteLine($"The grade is: {grade}");
    }
}
