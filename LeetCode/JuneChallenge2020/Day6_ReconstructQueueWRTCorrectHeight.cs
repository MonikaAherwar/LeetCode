using System.Linq;

namespace LeetCode.JuneChallenge2020
{
    class Day6_ReconstructQueueWRTCorrectHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var map = Enumerable.Range(0, people.Length).ToList();
            foreach (var person in people.OrderBy(p => p[0]).ThenByDescending(p => p[1]))
            {
                people[map[person[1]]] = new[] { person[0], person[1] };
                map.RemoveAt(person[1]);
            }

            return people;
        }
    }
}
