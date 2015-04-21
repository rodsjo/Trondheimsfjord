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
            _fromPicker = new Picker();
            foreach (var port in _ports)
            {
                _fromPicker.Items.Add(port.Name);
            }

            _toPicker = new Picker();
            foreach (var port in _ports)
            {
                _toPicker.Items.Add(port.Name);
            }

            Detail = new ContentPage()
            {
                Title = "Billetter",
                Content = new StackLayout()
                {
                    Children = 
                    {
                        _fromPicker,
                        _toPicker
                    }
                }
            };
        }
    }
}
