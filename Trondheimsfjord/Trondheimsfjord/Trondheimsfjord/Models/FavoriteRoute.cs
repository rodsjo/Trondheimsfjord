namespace Trondheimsfjord.Models
{
    public class FavoriteRoute : Route
    {
        public new string Name
        {
            get { return From.Name + " - " + To.Name; }
        }
    }
}
