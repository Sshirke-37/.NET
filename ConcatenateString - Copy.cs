// ConcatenateString.cs
using System;
public class ConcatenateString
{
    public static void Concatenate(string str1, string str2)
    {
        string result = str1 + " " + str2;
        Console.WriteLine($"Concatenated String: {result}");
    }
}