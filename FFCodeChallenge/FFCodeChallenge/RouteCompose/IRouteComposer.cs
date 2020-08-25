using FFCodeChallenge.RouteCompose.Model;

namespace FFCodeChallenge.RouteCompose
{
    public interface IRouteComposer
    {
        Route ComposeRouteFromData(string filepath);
    }
}