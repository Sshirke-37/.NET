// SumOfMultiple.cs
using System;

public class SumOfMultiple
{
    public static void sumofmultiples()
    {
        int sum = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"The sum of all multiples of 3 and 5 below {1000} is: {sum}");
    }
}
