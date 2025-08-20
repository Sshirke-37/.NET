// swap.cs
using System;

public class Swap
{
    public static void SwapNumbers(int a,int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}