using System;
using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;
using Trondheimsfjord.ViewCells;
using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    public class RoutePage : ContentPage
    {
        private Route _route;
        private readonly List<Port> _ports;
        
        private Picker _fromPicker;
        private Picker _toPicker;

        public RoutePage(Route route)
        {
            _route = route;
            _ports = Database.Database.GetPorts(_route.AtBRouteNr).ToList();

            Content = CreateGUI();
            Title = route.Name;
        }

        private Layout CreateGUI()
        {
            _fromPicker = new Picker
            {
                Title = "Fra",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            foreach (var port in _ports)
            {
                _fromPicker.Items.Add(port.Name);
            }

            _toPicker = new Picker
            {
                Title = "Til",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            foreach (var port in _ports)
            {
                _toPicker.Items.Add(port.Name);
            }
            
            //Set correct selected port in from- and to-picker
            var fromIndex = 0;
            var toIndex = _toPicker.Items.Count - 1;

            _fromPicker.SelectedIndex = fromIndex;
            _toPicker.SelectedIndex = toIndex;

            var routeTable = new ListView
            {
                ItemTemplate = new DataTemplate(typeof(DepartureCell)),
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var departures = Database.Database.GetDepartures(_route.AtBRouteNr, _route.From.Name, _route.To.Name, DateTime.Now.DayOfWeek).ToList();
            routeTable.ItemsSource = departures;

            var fromToGrid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition {Height = GridLength.Auto},
                    new RowDefinition {Height = GridLength.Auto}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = GridLength.Auto},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                }
            };

            var fromLabel = new Label
            {
                Text = "Fra",
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            var toLabel = new Label
            {
                Text = "Til",
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            fromToGrid.Children.Add(fromLabel, 0, 0);
            fromToGrid.Children.Add(_fromPicker, 1, 0);
            fromToGrid.Children.Add(toLabel, 0, 1);
            fromToGrid.Children.Add(_toPicker, 1, 1);
            
            return new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(10),
                Children = 
                {
                    fromToGrid,
                    new Label
                    {
                        Text = "Neste båt går om"
                    },
                    new Label
                    {
                        Text = _route.NextDepartureNiceTime + " (kl. " + _route.NextDepartureHourAndMinute + ")",
                        TextColor = Color.Accent
                    },
                    new Frame
                    {
                        Padding = new Thickness(0, 10, 0, 10),
                        Content = new Label
                        {
                            Text = Utilities.Utilities.GetRouteTableWeekdayTitle(_route)
                        }
                    },
                    routeTable
				}
            };
        }
    }
}
