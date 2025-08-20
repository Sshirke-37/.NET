// SumOfDigitOfaNumber.cs

using System;

public class SumOfDigitOfaNumber
{
    public static void CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"The sum of the digits is: {sum}");
    }
}