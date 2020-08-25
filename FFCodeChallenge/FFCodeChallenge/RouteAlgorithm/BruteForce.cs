using System.Collections.Generic;

namespace FFCodeChallenge.RouteAlgorithm
{
    public class BruteForce : IAlgorithms
    {
        List<List<int>> paths = new List<List<int>>();

        public (int, List<int>) RunBruteForce(int[][] triangle)
        {
            Recur(triangle, 0, 0, new List<int>());

            int maxValue = int.MinValue;
            List<int> maxPath = null;
            foreach (List<int> path in paths)
            {
                int tempValue = path[0];
                bool illegalPath = false;

                bool previousWasEven = IsEven(tempValue);
                for (int i = 1; i < path.Count; i++)
                {
                    if (IsEven(path[i]) != previousWasEven)
                    {
                        previousWasEven = !previousWasEven;
                        tempValue += path[i];
                    }
                    else { illegalPath = true; break; }
                }
                if (illegalPath) continue;
                if (tempValue > maxValue)
                {
                    maxValue = tempValue;
                    maxPath = path;
                }
            }
            return (maxValue, maxPath);
        }

        private void Recur(int[][] triangle, int i, int j, List<int> path)
        {
            if (path.Count > 0 && IsEven(path[path.Count - 1]) == IsEven(triangle[i][j]))
                return;

            if (triangle.Length - 1 == i)
            {
                path.Add(triangle[i][j]);
                paths.Add(new List<int>(path));
                path.RemoveAt(path.Count - 1);
            }
            else
            {
                path.Add(triangle[i][j]);
                Recur(triangle, i + 1, j, path);
                Recur(triangle, i + 1, j + 1, path);
                path.RemoveAt(path.Count - 1);
            }
        }

        private static bool IsEven(int value)
        {
            return (value % 2) == 0;
        }
    }
}
