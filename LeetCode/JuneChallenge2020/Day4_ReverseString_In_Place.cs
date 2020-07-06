using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.JuneChallenge2020
{
    class Day4_ReverseString_In_Place
    {
        public void ReverseString(char[] s)
        {
            var len = s.Length;
            for (var i = 0; i < len / 2; i++)
            {
                var temp = s[i];
                s[i] = s[len - i - 1];
                s[len - i - 1] = temp;
            }
        }
    }
}
