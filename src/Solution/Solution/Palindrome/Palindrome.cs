namespace Solution.Palindrome
{
    using System;
    using System.Linq;

    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            var normalizedInput = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

            Stack<char> stack = new Stack<char>();

            foreach (char ch in normalizedInput)
            {
                stack.Push(ch);
            }

            foreach (char ch in normalizedInput)
            {
                if (ch != stack.Pop()) {
                    return false;
                }
            }

            return true;
        }
    }
}
