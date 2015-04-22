using System.Collections.Generic;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Database
{
    internal class Database
    {
        public static IList<Port> GetPorts()
        {
            return new List<Port>
            {
                new Port {Name = "Trondheim"},
                new Port {Name = "Vanvikan"},
                new Port {Name = "Lensvik"},
                new Port {Name = "Hysnes"},
                new Port {Name = "Brekstad"},
                new Port {Name = "Sandstad"},
                new Port {Name = "Kjørsviksbugen"},
                new Port {Name = "Edøy"},
                new Port {Name = "Ringholmen"},
                new Port {Name = "Kristiansund"}
            };
        }

        public static IList<Route> GetRoutes()
        {
            return new List<Route>
            {
                new Route {Name = "Trondheim - Vanvikan"},
                new Route {Name = "Trondheim - Brekstad - Kristiansund"}
            };
        }
    }
}
