using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q5
{
    public static void Qs5()
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Validate the password
        if (IsPasswordValid(password))
        {
            Console.WriteLine("Password is valid.");
        }
        else
        {
            Console.WriteLine("Password is invalid. It must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
        }
    }

    static bool IsPasswordValid(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        bool hasUpperCase = false;
        bool hasLowerCase = false;
        bool hasNumber = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUpperCase = true;
            }
            else if (char.IsLower(c))
            {
                hasLowerCase = true;
            }
            else if (char.IsDigit(c))
            {
                hasNumber = true;
            }

            // If all criteria are met, we can return true early
            if (hasUpperCase && hasLowerCase && hasNumber)
            {
                return true;
            }
        }

        return hasUpperCase && hasLowerCase && hasNumber;
    }
}
