using System;
using System.Text;

namespace ass1
{
public static class StringBuilderExtensions
{
    public static int WordCount(this StringBuilder sb)
    {
        return sb.ToString().Split(new char[] {' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
    }
    
public static void Main(string[] args)
{
StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not.");
int wordCount = sb.WordCount();
Console.WriteLine(wordCount); // Output: 16
}
}
}