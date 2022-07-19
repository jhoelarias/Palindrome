namespace Palindrome;

internal class Program
{
    public static bool CheckPalindrome(string word)
    {
        var firstHalf = word[..(word.Length / 2)];
        var letters = word.ToCharArray();
        var middleIndex = word.Length % 2 == 0 ? firstHalf.Length : firstHalf.Length + 1;
        var secondHalfArray = letters[middleIndex..];
        Array.Reverse(secondHalfArray);
        string secondHalf = new(secondHalfArray);
        return firstHalf.Equals(secondHalf);
    }

    private static void Main(string[] args)
    {
        const string word = "wow";
        bool palindrome = CheckPalindrome(word);
        Console.WriteLine($"Is {word} palindrome? {palindrome}");
    }
}