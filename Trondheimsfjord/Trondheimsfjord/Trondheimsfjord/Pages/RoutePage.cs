using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;
using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    public class RoutePage : ContentPage
    {
        private Route _route;
        private FavoriteRoute _favRoute;
        public bool IsFavorite;
        private readonly List<Port> _ports;
        private Picker _fromPicker;
        private Picker _toPicker;

        public RoutePage(Route route)
        {
            _route = route;
            if (_route is FavoriteRoute)
            {
                IsFavorite = true;
                _favRoute = (FavoriteRoute) _route;
                _ports = Database.Database.GetPorts().ToList();
            }
            else
            {
                _ports = Database.Database.GetPorts(_route.AtBRouteNr).ToList();
            }
            
            Content = CreateGUI();
        }

        private Layout CreateGUI()
        {
            _fromPicker = new Picker
            {
                Title = "Fra",
                HorizontalOptions = LayoutOptions.Fill
            };
            foreach (var port in _ports)
            {
                _fromPicker.Items.Add(port.Name);
            }

            _toPicker = new Picker
            {
                Title = "Til",
                HorizontalOptions = LayoutOptions.Fill
            };
            foreach (var port in _ports)
            {
                _toPicker.Items.Add(port.Name);
            }
            
            //Set correct selected port in from- and to-picker
            var fromIndex = 0;
            var toIndex = _toPicker.Items.Count - 1;

            if (IsFavorite)
            {
                for (var i = 0; i < _fromPicker.Items.Count; i++)
                {
                    var portName = _fromPicker.Items[i];
                    if (portName == _favRoute.From.Name)
                        fromIndex = i;
                }
                for (var i = 0; i < _toPicker.Items.Count; i++)
                {
                    var portName = _toPicker.Items[i];
                    if (portName == _favRoute.To.Name)
                        toIndex = i;
                }
            }
            _fromPicker.SelectedIndex = fromIndex;
            _toPicker.SelectedIndex = toIndex;

            return new StackLayout
            {
                Children = 
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Fill,
                        VerticalOptions = LayoutOptions.End,
                        Children =
                        {
                            new Label { Text = "Fra" },
                            _fromPicker
                        }
                    },
					new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Fill,
                        VerticalOptions = LayoutOptions.End,
                        Children =
                        {
                            new Label { Text = "Til" },
                            _toPicker
                        }
                    },
				}
            };
        }
    }
}
