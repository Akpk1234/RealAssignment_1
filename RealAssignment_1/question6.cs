using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q6
{
    public static void Qs6()
    {
        const double flatRate = 20.0;
        const double perKmRate = 10.0;
        const double nightSurcharge = 1.2; // 20% surcharge
        const int nightStartHour = 22;

        Console.Write("Enter the distance traveled in kilometers: ");
        string distanceInput = Console.ReadLine();
        Console.Write("Enter the hour of the ride (0-23): ");
        string hourInput = Console.ReadLine();

        if (double.TryParse(distanceInput, out double distance) && int.TryParse(hourInput, out int hour) && distance >= 0 && hour >= 0 && hour <= 23)
        {
            double fare = 0;

            // Calculate the fare based on distance
            if (distance <= 2)
            {
                fare = flatRate;
            }
            else
            {
                fare = flatRate + ((distance - 2) * perKmRate);
            }

            // Apply night surcharge if applicable
            if (hour >= nightStartHour || hour < 6) // Assuming night time is from 10 PM to 6 AM
            {
                fare *= nightSurcharge;
            }

            Console.WriteLine("The total fare is: Rs. " + fare);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid distance and hour.");
        }
    }
}