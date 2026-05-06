using System;
using System.Text;
using System.Linq;
public class StringManipulator
{
    public string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public string ToUpperCase(string input)
    {
        return input.ToUpper();
    }
    public string ToLowerCase(string input)
    {
        return input.ToLower();
    }
    public int CountVowels(string input)
    {
        return input.Count(c => "aeiouAEIOU".Contains(c));
    }
    public string RemoveWhitespace(string input)
    {
        return string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }
    public string Concatenate(params string[] strings)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strings)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }
    public bool IsPalindrome(string input)
    {
        string reversed = Reverse(input);
        return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
    }
    public string[] SplitString(string input, char delimiter)
    {
        return input.Split(delimiter);
    }
    public string Replace(string input, string oldValue, string newValue)
    {
        return input.Replace(oldValue, newValue);
    }
    public string[] GetWords(string input)
    {
        return RemoveWhitespace(input).Split(' ');
    }
}
