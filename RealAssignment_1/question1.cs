using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the prices of the 5 items
            double[] prices = { 500, 1000, 1200, 800, 600 };

            // Calculate the total price
            double totalPrice = 0;
            foreach (double price in prices)
            {
                totalPrice += price;
            }

            // Check if the total price exceeds Rs. 3000
            if (totalPrice > 3000)
            {
                // Apply a 10% discount
                totalPrice *= 0.90;
            }

            // Output the total price
            Console.WriteLine("The total price of the items in the cart is: Rs. " + totalPrice);

            Q2.Qs2();
            Console.WriteLine();

            Q3.Qs3();
            Console.WriteLine();

            Q4.Qs4();
            Console.WriteLine();

            Q5.Qs5();
            Console.WriteLine();

            Q6.Qs6();
            Console.WriteLine();

            Q7.Qs7();
            Console.WriteLine();

            Q8.Qs8();
            Console.WriteLine();

            Q10.Qs10();
            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
