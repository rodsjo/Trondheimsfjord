using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class MapPage : RootMaterDetailPage
    {
        public MapPage()
        {
            Detail = new ContentPage()
            {
                Title = "Kart",
                Content = new StackLayout()
                {
                    Children = 
                    {
                        new Label()
                        {
                            Text = "Kart",
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center
                        }
                    }
                }
            };
        }
    }
}
