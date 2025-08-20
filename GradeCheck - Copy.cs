// Grade.cs
using System;
public class Grade
{
    public static void CheckGradeStats(string grade)
    {
        if (grade == "A")
        {
            Console.WriteLine($"{grade} = Excellent");
        }
        else if (grade == "B") 
        {
            Console.WriteLine($"{grade}  = Good");
        }
        else if (grade == "C")
        {
            Console.WriteLine($"{grade} = Average");
        }
        else if (grade == "D")
        {
            Console.WriteLine($"{grade} = Below Average");
        }
        else if (grade == "F")
        {
            Console.WriteLine($"{grade} = Fail");
        }
        else
        {
            Console.WriteLine("Invalid grade input.");
        }
    }
}