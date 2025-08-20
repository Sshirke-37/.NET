// Program.cs
using System;
class Program
{
    static void Main(string[] args)
    {
        //Even Odd
        int myNumber = 7;
        EvenOdd.CheckEvenOrOdd(myNumber);
        //Console.ReadLine();

        //Postive Negative
        int positiveNegativeNumber = 0;
        PositiveNegative.CheckPositiveNegative(positiveNegativeNumber);

        //Greater amongst three numbers
        int num1 = -200, num2 = -100, num3 = -300;
        LargestNumber.CheckLargeNumber(num1, num2, num3);

        //Swap two numbers
        int a = 10, b = 30;
        Swap.SwapNumbers(a, b);

        //Sum of the multiples of 3 and 5 
        SumOfMultiple.sumofmultiples();

        //Sum of a digit of a number
        SumOfDigitOfaNumber.CalculateSumOfDigits(12345);

        //Reverse a number and check palindrome or not
        ReverseNumberAndCheckPalindrome.ReverseAndCheckPalindrome(91519);

        //Add,Sub,Mul,Div
        Arithmetic.Calculate(10, 2);

        //Check Grade Equivalent
        Grade.CheckGradeStats("A");

        //Upper To Lower Case and vise a versa
        CaseCheck.CheckUpperLower('H');
        CaseCheck.CheckUpperLower('h');

        //Armstrong Number
        Armstrong.CheckArmstrong(153);

        //Reverse a number
        ReverseNumber.Reverse(1287);

        //Concatenate two strings
        ConcatenateString.Concatenate("Soham", "Shirke");

        //Length of a string
        LengthString.PrintLength("Soham Shirke");
    }
}