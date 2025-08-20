// ReverseNumber.cs

using System;

public class ReverseNumber
{
    public static void Reverse(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        Console.WriteLine($"Reversed Number: {reversed}");
    }
}