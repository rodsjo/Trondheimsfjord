namespace Trondheimsfjord.Models
{
    public class FavoriteRoute : Route
    {
        public Port From { get; set; }
        public Port To { get; set; }

        public new string Name
        {
            get { return From.Name + " - " + To.Name; }
        }

        public Departure NextDeparture
        {
            get
            {
                return Database.Database.GetNextDeparture(AtBRouteNr, From.Name, To.Name);
            }
        }
        public string NextBoatLeavesIn
        {
            get
            {
                var nextDeparture = NextDeparture;
                var niceTimeString = Utilities.Utilities.NiceTime(nextDeparture.DepartureTime);
                return "Neste båt går om " + niceTimeString;
            }
        }
    }
}
