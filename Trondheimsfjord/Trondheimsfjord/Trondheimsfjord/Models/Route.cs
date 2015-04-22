using System.Collections.Generic;

namespace Trondheimsfjord.Models
{
    public class Route
    {
        public string Name { get; set; }
        public int AtBRouteNr { get; set; }

        public string AtBRouteNrString
        {
            get { return "AtB rute " + AtBRouteNr; }
        }
        public IList<Port> Ports { get; set; }
        public IList<Boat> Boats { get; set; }
    }
}
