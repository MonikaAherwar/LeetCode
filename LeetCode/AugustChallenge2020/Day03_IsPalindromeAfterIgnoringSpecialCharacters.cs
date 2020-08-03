using System;

namespace LeetCode.AugustChallenge2020
{
    class Day03_IsPalindromeAfterIgnoringSpecialCharacters
    {
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                else if (!Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                else if (Char.ToUpperInvariant(s[i]) == char.ToUpperInvariant(s[j]))
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
