// UpperLower.cs
using System;
public class CaseCheck
{
    public static void CheckUpperLower(char character)
    {
        if (char.IsUpper(character))
        {
            Console.WriteLine($"{character} is an uppercase letter.");
            Console.WriteLine($"Converting the {character} to lower case: " +character.ToString().ToLower());
        }
        else if (char.IsLower(character))
        {
            Console.WriteLine($"{character} is a lowercase letter.");
            Console.WriteLine($"Converting the {character} to upper case: " + character.ToString().ToUpper());
        }
        else
        {
            Console.WriteLine($"{character} is not an alphabetic character.");
        }
    }
}