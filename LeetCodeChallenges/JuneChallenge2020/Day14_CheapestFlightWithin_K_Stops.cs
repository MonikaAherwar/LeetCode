using System.Collections.Generic;

namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day14_CheapestFlightWithin_K_Stops
    {
        private Dictionary<int, Dictionary<int, int>> dic;
        private int minimumCost = int.MaxValue;

        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            dic = new Dictionary<int, Dictionary<int, int>>(n);
            foreach (var flight in flights)
            {
                var key = flight[0];
                if (dic.ContainsKey(key))
                    dic[key].Add(flight[1], flight[2]);
                else
                    dic.Add(key, new Dictionary<int, int>(n) {
                        { flight[1], flight[2] }
                    });
            }

            DFS(src, dst, K + 1, 0);

            return minimumCost == int.MaxValue ? -1 : minimumCost;
        }

        // dfs(Depth fisrt search):Dijkestra
        private void DFS(int src, int dst, int K, int cost)
        {
            if (K < 0) return;

            if (src == dst)
            {
                minimumCost = cost;
                return;
            }

            if (!dic.ContainsKey(src)) return;

            var destins = dic[src];
            foreach (var destin in destins)
            {
                var newCost = cost + destin.Value;
                if (newCost > minimumCost)
                    continue;
                DFS(destin.Key, dst, K - 1, newCost);
            }
        }
    }
}
