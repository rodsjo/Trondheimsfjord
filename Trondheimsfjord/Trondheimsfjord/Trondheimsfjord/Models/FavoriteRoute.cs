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

        public string NextBoatLeavesIn
        {
            get { return "Neste båt går om 25 minutter"; }
        }
    }
}
