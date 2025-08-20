// LargestNumber.cs
using System;
public class LargestNumber
{
    public static void CheckLargeNumber(int num1 , int num2 , int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine($"{num1} is greater than {num2} and {num3}.");
        }
        else if (num2 >= num1 && num2 >= num3)
        { 
            Console.WriteLine($"{num2} is greater than {num1} and {num3}.");
        }
        else
        {
            Console.WriteLine($"{num3} is greater than {num1} and {num2}.");
        }
    }
}