using System.Text;

namespace LeetCode.JulyChallenge2020
{
    class Day19_AddBinaryStrings
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                int sum = ((i >= 0 ? a[i] - '0' : 0) + (j >= 0 ? b[j] - '0' : 0)) + carry;
                sb.Insert(0, sum == 2 || sum == 0 ? '0' : '1');
                carry = sum > 1 ? 1 : 0;
            }

            return carry == 1 ? sb.Insert(0, 1).ToString() : sb.ToString();
        }
    }
}
