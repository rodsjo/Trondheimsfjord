using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class RoutesPage : RootMaterDetailPage
    {
        public RoutesPage() 
        {
            Detail = new ContentPage()
            {
                Title = "Båtruter",
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
                            Text = "Trondheim - Brekstad - Kristiansund"
                        }
                    }
                }
            };
        }
    }
}
