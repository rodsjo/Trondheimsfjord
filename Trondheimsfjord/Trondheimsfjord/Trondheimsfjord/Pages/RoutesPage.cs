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
                ItemsSource = _routes
            };

            return new ContentPage()
            {
                Title = "Båtruter",
                Content = routesListView
            };
        }
    }
}
