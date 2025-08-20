// PerfectNumber.cs
using System;
public class PerfectNumber
{
    public static void CheckPerfectNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        if (sum == number)
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }
}