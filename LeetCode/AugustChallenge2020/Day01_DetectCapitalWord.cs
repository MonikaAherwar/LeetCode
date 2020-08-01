namespace LeetCode.AugustChallenge2020
{
    class Day01_DetectCapitalWord
    {
        public bool DetectCapitalUse(string word)
        {
            if (word == "")
            {
                return true;
            }

            bool allUpperCase = word == word.ToUpper();
            bool substringAfterFirstLetterIsLowerCase = word.Substring(1) == word.Substring(1).ToLower();

            return (allUpperCase || substringAfterFirstLetterIsLowerCase);
        }
    }
}
