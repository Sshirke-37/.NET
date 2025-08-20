// ReverseAndCheckPalindrome.cs
using System;
public class ReverseNumberAndCheckPalindrome
{   public static void ReverseAndCheckPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        Console.WriteLine($"Reversed Number: {reversedNumber}");
        if (originalNumber == reversedNumber)
        {
            Console.WriteLine($"{originalNumber} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a palindrome.");
        }
    }
}