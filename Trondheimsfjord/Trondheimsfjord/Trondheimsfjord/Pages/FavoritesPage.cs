using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;
using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class FavoritesPage : RootMaterDetailPage
    {
        private List<FavoriteRoute> _favoriteRoutes = Database.Database.GetFavoriteRoutes().ToList();
        private bool _noFavorites;

        public FavoritesPage()
        {
            if (!_favoriteRoutes.Any())
                _noFavorites = true;

            Detail = CreateGUI();
        }

        private Page CreateGUI()
        {
            if (_noFavorites)
            {
                return new ContentPage()
                {
                    Title = "Favoritter",
                    Padding = new Thickness(10),
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Label
                            {
                                Text = "Sry, du har ingen favoritter",
                                HorizontalOptions = LayoutOptions.Center,
                                VerticalOptions = LayoutOptions.Center
                            }
                        }
                    }
                };
            }

            var routesListView = new ListView
            {
                ItemTemplate = new DataTemplate(typeof(TextCell)),
            };
            routesListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            routesListView.ItemTemplate.SetBinding(TextCell.DetailProperty, "NextDepartureNiceTime");
            routesListView.ItemsSource = _favoriteRoutes;
            routesListView.ItemTapped += routesListView_ItemTapped;

            return new ContentPage()
            {
                Title = "Favoritter",
                Padding = new Thickness(10),
                Content = new ScrollView
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Orientation = ScrollOrientation.Vertical,
                    Content = routesListView
                }
            };
        }

        void routesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var favRoute = (FavoriteRoute)e.Item;
            ((ListView)sender).SelectedItem = null; // Deselect the row
            Navigation.PushAsync(new RoutePage(favRoute));
        }
    }
}
