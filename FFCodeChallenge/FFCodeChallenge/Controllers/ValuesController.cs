﻿using Microsoft.AspNetCore.Mvc;
using FFCodeChallenge.DataInputHandler;
using FFCodeChallenge.RouteCompose.Model;
using FFCodeChallenge.RouteCompose;

namespace FFCodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRouteComposer _RouteComposer;
        public ValuesController(IRouteComposer routeComposer)
        {
            _RouteComposer = routeComposer;
        }
        [HttpPost("RouteFromPyramidData")]
        public Route FindRouteTriangleData(string filepath)
        {
            const string filePath = "1.txt";
            var RouteData = _RouteComposer.ComposeRouteFromData(filePath);

            return RouteData;
        }
    }
}
