using System;
public class Armstrong
{
    public static void CheckArmstrong(int number)
    {
        int originalNumber = number;
        int digits = 0;
        int temp = number;

        // Count digits without using ToString()
        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }

        int sum = 0;
        temp = number;

        // Calculate sum of digits raised to the power of 'digits'
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}