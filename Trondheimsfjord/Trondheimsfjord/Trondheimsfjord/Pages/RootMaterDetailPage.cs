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
                    Children =
                    {
                        new Button()
                        {
                            Text = "Favoritter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                        },
                        new Button()
                        {
                            Text = "Båtruter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button()
                        {
                            Text = "Billetter",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button()
                        {
                            Text = "Kart",
                            Font = Font.SystemFontOfSize(NamedSize.Large),
                            HorizontalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            return menu;
        }
    }
}
