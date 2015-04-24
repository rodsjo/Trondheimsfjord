using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class RootMaterDetailPage : MasterDetailPage
    {
        public RootMaterDetailPage()
        {
            Master = BuildMenu();
        }

        private Page BuildMenu()
        {
            var menu = new ContentPage()
            {
                Title = "Meny",
                Content = new StackLayout()
                {
                    BackgroundColor = Color.FromHex("#333"),
                    Children =
                    {
                        new Button()
                        {
                            Text = "Favoritter",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() => Navigation.PushAsync(new FavoritesPage()))
                        },
                        new Button()
                        {
                            Text = "Båtruter",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() => Navigation.PushAsync(new RoutesPage()))
                        },
                        new Button()
                        {
                            Text = "Billetter",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() => Navigation.PushAsync(new TicketsPage()))
                        },
                        new Button()
                        {
                            Text = "Kart",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() => Navigation.PushAsync(new MapPage()))
                        }
                    }
                }
            };
            return menu;
        }
    }
}
