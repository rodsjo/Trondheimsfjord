using Xamarin.Forms;

namespace Trondheimsfjord
{
    internal class Favorites : Main
    {
        public Favorites()
        {
            Detail = new ContentPage()
            {
                Content = new Label {Text = "This is the first page"}
            };
        }
    }
}
