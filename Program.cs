using System;
using System.Security.Cryptography.X509Certificates;
namespace Assignment2
{
    internal class Program
    {
        //Even-Odd Function
        static void CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
            { 
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }
        }

        //Positive-Negative Function
        static void CheckPostiveNegative(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine($"{num} is Positive");
            }
            else
            {
                Console.WriteLine($"{num} is Negative");
            }
        }

        //Finding the largest of three numbers
        static void FindLargest(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"{num1} is greater than {num2},{num3}");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"{num2} is greater than {num1},{num3}");
            }
            else
            {
                Console.WriteLine($"{num3} is greater than {num1},{num2}");
            }
        }

        //Swap 2 numbers
        static void SwapNumbers(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }

        //Sum of all the multiples of 3 and 5
        static void FindSumOfMultiples(int limit)
            {
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all multiples of 3 and 5 below {limit} is {sum}");
        }

        //Sum of digits of a number
        static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of the given number is: "+sum);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CheckEvenOdd(4);
            CheckPostiveNegative(0);
            FindLargest(-100, 0, -200);
            SwapNumbers(20, 60);
            FindSumOfMultiples(10000);
            SumOfDigits(153);
        }



    }
}
