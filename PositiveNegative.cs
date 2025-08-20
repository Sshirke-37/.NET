// EvenOdd.cs

using System;

public class PositiveNegative
{
    public static void CheckPositiveNegative(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"{number} is negative.");
        }
        else
        {
            Console.WriteLine($"{number} is positive.");
        }
    }
}