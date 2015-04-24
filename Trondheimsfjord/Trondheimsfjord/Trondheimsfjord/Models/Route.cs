using System.Collections.Generic;

namespace Trondheimsfjord.Models
{
    public class Route
    {
        public string Name { get; set; }
        public int AtBRouteNr { get; set; }

        public Port From { get; set; }
        public Port To { get; set; }

        public string AtBRouteNrString
        {
            get { return "AtB rute " + AtBRouteNr; }
        }
        public IList<Port> Ports { get; set; }
        public IList<Boat> Boats { get; set; }

        public Departure NextDeparture
        {
            get
            {
                var nextDeparture = Database.Database.GetNextDeparture(AtBRouteNr, From.Name, To.Name);
                return nextDeparture;
            }
        }
        public string NextDepartureHourAndMinute
        {
            get
            {
                var nextDeparture = NextDeparture;
                var hourAndMinuteTimeString = Utilities.Utilities.HourAndMinuteTime(nextDeparture.DepartureTime);
                return hourAndMinuteTimeString;
            }
        }
        public string NextDepartureNiceTime
        {
            get
            {
                var nextDeparture = NextDeparture;
                var niceTimeString = Utilities.Utilities.NiceTime(nextDeparture.DepartureTime);
                return niceTimeString;
            }
        }

        public string NextDepartureNiceTimeWithPrefix
        {
            get { return "Neste båt går om " + NextDepartureNiceTime; }
        }
    }
}
