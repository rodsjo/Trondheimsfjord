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
                    BackgroundColor = Color.FromHex("#ccc"),
                    Children =
                    {
                        new Button
                        {
                            Text = "Båtruter",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() =>
                            {
                                IsPresented = false;
                                Navigation.PushAsync(new RoutesPage());
                            })
                        },
                        new Button
                        {
                            Text = "Kart",
                            Font = Font.SystemFontOfSize(NamedSize.Default),
                            HorizontalOptions = LayoutOptions.Fill,
                            Command = new Command(() =>
                            {
                                IsPresented = false;
                                Navigation.PushAsync(new MapPage());
                            })
                        }
                    }
                }
            };
            return menu;
        }
    }
}
