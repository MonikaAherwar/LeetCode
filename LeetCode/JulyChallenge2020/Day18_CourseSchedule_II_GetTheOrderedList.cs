using System.Collections.Generic;

namespace LeetCode.JulyChallenge2020
{
    class Day18_CourseSchedule_II_GetTheOrderedList
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            List<int> result = new List<int>();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            int[] indegree = new int[numCourses];
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            int count = 0;

            if (prerequisites == null || prerequisites.Length == 0)
            {
                for (int i = 0; i < numCourses; i++)
                    result.Add(i);

                return result.ToArray();
            }

            for (int i = 0; i < numCourses; i++)
                graph.Add(i, new List<int>());

            for (int i = 0; i < prerequisites.Length; i++)
            {
                graph[prerequisites[i][0]].Add(prerequisites[i][1]);
                indegree[prerequisites[i][1]]++;
            }

            for (int i = 0; i < indegree.Length; i++)
                if (indegree[i] == 0)
                    queue.Enqueue(i);

            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();

                stack.Push(cur);

                foreach (var node in graph[cur])
                    if (--indegree[node] == 0)
                        queue.Enqueue(node);

                count++;
            }

            if (count == numCourses)
                while (stack.Count > 0)
                    result.Add(stack.Pop());

            return count != numCourses ? new int[] { } : result.ToArray();
        }
    }
}
