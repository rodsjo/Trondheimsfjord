using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;
using Xamarin.Forms;

namespace Trondheimsfjord.Pages
{
    internal class TicketsPage : RootMaterDetailPage
    {
        private readonly List<Port> _ports = Database.Database.GetPorts().ToList();
        private Picker _fromPicker;
        private Picker _toPicker;

        public TicketsPage()
        {
            Detail = CreateGUI();
        }

        private Page CreateGUI()
        {
            _fromPicker = new Picker { Title = "Fra" };
            foreach (var port in _ports)
            {
                _fromPicker.Items.Add(port.Name);
            }
            _fromPicker.SelectedIndex = 0;

            _toPicker = new Picker
            {
                Title = "Til"
            };
            foreach (var port in _ports)
            {
                _toPicker.Items.Add(port.Name);
            }
            _toPicker.SelectedIndex = 1;

            return new ContentPage()
            {
                Title = "Billetter",
                Content = new StackLayout()
                {
                    Children = 
                    {
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Fra"
                                },
                                _fromPicker
                            }
                        },
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label()
                                {
                                    Text = "Til"
                                },
                                _toPicker
                            }
                        },
                    }
                }
            };
        }
    }
}
