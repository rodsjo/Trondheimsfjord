using System.Collections.Generic;

namespace Trondheimsfjord.Models
{
    internal class Route
    {
        public string Name;
        public IList<Port> Ports;
        public IList<Boat> Boats;
    }
}
