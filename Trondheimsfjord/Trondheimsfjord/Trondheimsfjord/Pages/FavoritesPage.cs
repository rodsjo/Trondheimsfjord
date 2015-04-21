using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class FavoritesPage : RootMaterDetailPage
    {
        public FavoritesPage()
        {
            Detail = new ContentPage()
            {
                Title = "Favoritter",
                Content = new StackLayout()
                {
                    Children = 
                    {
                        new Label()
                        {
                            Text = "Trondheim - Vanvikan"
                        },
                        new Label()
                        {
                            Text = "Trondheim - Brekstad"
                        },
                        new Label()
                        {
                            Text = "Kristiansund - Lensvik"
                        },
                        new Label()
                        {
                            Text = "Hysnes - Brekstad"
                        }
                    }
                }
            };
        }
    }
}
