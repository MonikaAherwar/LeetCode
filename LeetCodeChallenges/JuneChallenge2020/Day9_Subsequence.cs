namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day9_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            var m = s.Length;
            var n = t.Length;

            if (m == 0)
            {
                return true;
            }

            var j = 0;
            for (var i = 0; i < n; i++)
            {
                if (t[i] == s[j])
                {
                    j++;

                    if (j == m) return true;
                }
            }

            return (j == m);
        }
    }
}
