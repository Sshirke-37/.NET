//Assignment 02 - Delegates

using System;
namespace AssignmentDelegates
{ 
    public delegate void AddDelegate(int a, int b);
    public delegate void PalindromeDelegate(int num);
    public delegate void CalculateDelegate(int a , int b);
    public delegate void GradeDelegate(char grade);
    public delegate void CaseDelegate(char ch);
    public delegate void PerfectDelegate(int num);
    public delegate void ArmstrongDelegate(int num);
    public delegate void ReverseDelegate(int num);
    public delegate void ConcatenateDelegate(string str1, string str2);
    public delegate void LengthDelegate(string str);
    internal class AssignmentDelegates
    {
        public void addNum(int a, int b)
        { 
            Console.WriteLine("Addition is: " + (a + b));
        }

        //Palindrome Method
        public void numPalindrome(int num)
        {
            int r, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                r = num % 10; //getting remainder
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine("palindrome number");
            else
                Console.WriteLine("not palindrome");
        }


        //Add , Sub ,Mul ,Div Method
        public void calculate(int a, int b)
        {
            Console.WriteLine("Addition is: " + (a + b));
            Console.WriteLine("Subtraction is: " + (a - b));
            Console.WriteLine("Multiplication is: " + (a * b));
            Console.WriteLine("Division is: " + (a / b));
        }

        //Read Grade and Display Equivalent Method
        public void gradeEquivalent(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Average");
                    break;
                case 'E':
                    Console.WriteLine("Below Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }

        //Convert alphabets Upper and Lower Case Method
        public void caseConvert(char ch)
        {
            if (char.IsLower(ch))
            {
                Console.WriteLine("Converted to the upper case: "+char.ToUpper(ch));
            }
            else if (char.IsUpper(ch))
            {
                Console.WriteLine("Converted to lower case: "+char.ToLower(ch));
            }
            else
            {
                Console.WriteLine("Not an alphabet");
            }
        }


        //Perfect Number Method
        public void perfectNum(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
        }

        //Armstrong Number Method
        public void armstrongNum(int num)
        {
            int r, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                r = num % 10; //getting remainder
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("not Armstrong number");
        }

        //Reverse Number Method
        public void reverseNum(int num)
        {
            int r, sum = 0;
            while (num > 0)
            {
                r = num % 10; //getting remainder
                sum = (sum * 10) + r;
                num = num / 10;
            }
            Console.WriteLine("Reversed Number is: " + sum);
        }

        //Concatenate two strings Method
        public void concatenateString(string str1, string str2)
        { 
            Console.WriteLine("Concatenated String is: " + str1 + str2);
        }


        //Length of String Method
        public void lengthOfString(string str)
        {
            Console.WriteLine("Length of String is: " + str.Length);
        }

        static void Main(string[] args)
        {
            AssignmentDelegates obj = new AssignmentDelegates();
            
            //Addition Test
            //AddDelegate del = new AddDelegate(obj.addNum);
            //del(10, 20);

            //Palindrome
            PalindromeDelegate del1 = new PalindromeDelegate(obj.numPalindrome);
            del1(121);

            //Add, Sub, Mul, Div
            CalculateDelegate del2 = new CalculateDelegate(obj.calculate);
            del2(20, 10);

            //Grade Equivalent
            GradeDelegate del3 = new GradeDelegate(obj.gradeEquivalent);
            del3('A');

            //Upper and Lower Case
            CaseDelegate del4 = new CaseDelegate(obj.caseConvert);
            del4('X');

            //Perfect  Number 
            PerfectDelegate del5 = new PerfectDelegate(obj.perfectNum);
            del5(28);


            //Armstrong Number
            ArmstrongDelegate del6 = new ArmstrongDelegate(obj.armstrongNum);
            del6(153);

            //Reverse Number
            ReverseDelegate del7 = new ReverseDelegate(obj.reverseNum);
            del7(12345);

            //Concatenate two strings
            ConcatenateDelegate del8 = new ConcatenateDelegate(obj.concatenateString);
            del8("SOHAM ", "SHIRKE");

            //Length of String
            LengthDelegate del9 = new LengthDelegate(obj.lengthOfString);
            del9("soham");

            Console.ReadLine();
        }//main method

    }//class

}//Namespace