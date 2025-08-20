// arithemtic.cs

using System;

public class Arithmetic
{
    public static void Calculate(int a , int b)
    {
        int Addresult;
        Addresult = a + b;
        Console.WriteLine($"Addition of {a} and {b} is: {Addresult}");
        int Subresult;  
        Subresult = a - b;
        Console.WriteLine($"Subtraction of {a} and {b} is: {Subresult}");
        int Mulresult;
        Mulresult = a * b;
        Console.WriteLine($"Multiplication of {a} and {b} is: {Mulresult}");
        int Divresult;
        if (b != 0)
        {
            Divresult = a / b;
            Console.WriteLine($"Division of {a} and {b} is: {Divresult}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
    }
}