using System;

namespace LeetCode.JulyChallenge2020
{
    class Day15_ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            var stringArray = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(stringArray);
            return string.Join(' ', stringArray);
        }
    }
}
