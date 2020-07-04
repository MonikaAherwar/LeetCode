using System;

namespace LeetCodeChallenges.JulyChallenge2020
{
    class Day03_PrisionCellsAfterNDays
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {

            var len = cells.Length;
            N = N % 14 == 0 ? 14 : N % 14;

            for (int j = 0; j < N; j++)
            {
                var result = new int[len];
                for (int i = 1; i < len - 1; i++)
                {
                    result[i] = cells[i - 1] == cells[i + 1] ? 1 : 0;
                }

                Array.Copy(result, 0, cells, 0, len);
            }

            return cells;
        }
    }
}
