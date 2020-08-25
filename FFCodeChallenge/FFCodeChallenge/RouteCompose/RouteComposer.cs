using System.Collections.Generic;
using System.Diagnostics;
using FFCodeChallenge.DataInputHandler;
using FFCodeChallenge.RouteAlgorithm;
using FFCodeChallenge.RouteCompose.Model;

namespace FFCodeChallenge.RouteCompose
{
    public class RouteComposer : IRouteComposer
    {
        private IFormatPyramidData _FormatPyramidData;

        public RouteComposer(IFormatPyramidData formatPyramidData)
        {
            _FormatPyramidData = formatPyramidData;
        }

        public Route ComposeRouteFromData(string filepath)
        {
            //Håndtere data fra fil
            var formattedData = _FormatPyramidData.GetFormattedData(filepath);

            //Tidsmåling/iteration start
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int iterations = 100000;

            (int, List<int>) resultPair = (int.MinValue, null);
            for (int i = 0; i < iterations; i++)
            {
                //Løber data igennem og skaber rute
                IAlgorithms solver = new BruteForce();
                resultPair = solver.RunBruteForce(formattedData);                
            }
            sw.Stop();

            var RouteInformation = new Route(resultPair.Item1, resultPair.Item2, iterations, sw.Elapsed);

            return RouteInformation;


        }
    }
}
