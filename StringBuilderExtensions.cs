public static class StringBuilderExtensions
{
    public static int WordCount(this StringBuilder sb)
    {
        return sb.ToString().Split(' ').Length;
    }
}

StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
int wordCount = sb.WordCount();
Console.WriteLine(wordCount); // Output: 16
