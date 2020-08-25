using System.Collections.Generic;

namespace FFCodeChallenge.RouteAlgorithm
{
    public interface IAlgorithms
    {
        (int, List<int>) RunBruteForce(int[][] triangle);
    }
}