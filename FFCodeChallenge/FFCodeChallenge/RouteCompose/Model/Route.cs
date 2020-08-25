using System;
using System.Collections.Generic;

namespace FFCodeChallenge.RouteCompose.Model
{
    public class Route
    {
        public int MaxSum { get; }
        public List<int> RouteTravelled { get; }
        public int AlgorithmsIterations { get; }
        public TimeSpan AlgoríthmTime { get; }

        public Route(int sum, List<int> routetravelled, int algorithmsIterations, TimeSpan algorithmTime)
        {
            MaxSum = sum;
            RouteTravelled = routetravelled;
            AlgorithmsIterations = algorithmsIterations;
            AlgoríthmTime = algorithmTime;
        }
    }
}
