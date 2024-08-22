using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q2
{
    public static void Qs2()
    {
        Console.Write("Enter the temperature in Celsius: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double celsiusTemperature))
        {
            // Convert Celsius to Fahrenheit
            double fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;

            // Display the Fahrenheit temperature
            Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheitTemperature);

            // Check for freezing temperature
            if (celsiusTemperature < 0)
            {
                Console.WriteLine("Warning: The temperature is below freezing!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}


