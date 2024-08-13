public class Program
{
    public static void Main(string[] args)
    {
        PalindromeChecker checker = new PalindromeChecker();
        
        int number = 133; // Example number to check
        bool result = checker.IsPalindrome(number);
        
        Console.WriteLine($"Is {number} a palindrome? {result}");
    }
}

public class PalindromeChecker
{
    public bool IsPalindrome(int x)
    {
        // Convert the integer to a string
        string number = x.ToString();
        
        // Check if the string reads the same forwards and backwards
        string reversedNumber = new string(number.Reverse().ToArray());
        
        // Return whether the original string is equal to the reversed string
        return number == reversedNumber;
    }
}
