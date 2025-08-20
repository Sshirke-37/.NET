// EvenOdd.cs

using System;

public class EvenOdd
{
    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }
}