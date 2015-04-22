using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;
using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class RoutesPage : RootMaterDetailPage
    {
        private readonly List<Route> _routes = Database.Database.GetRoutes().ToList();

        public RoutesPage()
        {
            Detail = CreateGUI();
        }

        private Page CreateGUI()
        {
            var routesListView = new ListView
            {
                ItemTemplate = new DataTemplate(typeof (TextCell))
            };
            routesListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            routesListView.ItemTemplate.SetBinding(TextCell.DetailProperty, "AtBRouteNrString");

            routesListView.ItemsSource = _routes;
            
            routesListView.ItemTapped += routesListView_ItemTapped;

            return new ContentPage()
            {
                Title = "Båtruter",
                Content = routesListView
            };
        }

        void routesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var route = (Route)e.Item;
            ((ListView)sender).SelectedItem = null; // Deselect the row
            Navigation.PushAsync(new RoutePage(route));
        }
    }
}
