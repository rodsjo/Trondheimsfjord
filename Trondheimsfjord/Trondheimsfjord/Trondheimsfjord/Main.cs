using Xamarin.Forms;

namespace Trondheimsfjord
{
    class Main : MasterDetailPage
    {
        public Main()
        {
            Master = BuildMenu();
        }

        private Page BuildMenu()
        {
            var menu = new ContentPage()
            {
                Title = "Master",
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Button()
                        {
                            Text = "Favoritter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button()
                        {
                            Text = "Favoritter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button()
                        {
                            Text = "Favoritter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            return menu;
        }
    }
}
