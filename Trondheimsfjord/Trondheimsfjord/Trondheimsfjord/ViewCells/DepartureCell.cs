using Xamarin.Forms;

namespace Trondheimsfjord.ViewCells
{
    public class DepartureCell : ViewCell
    {
        public DepartureCell()
        {

            var timeLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Start,
                TextColor = Color.Accent,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            timeLabel.SetBinding(Label.TextProperty, "DepartureTimeString");

            var alarmBtn = new Image
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                Source = ImageSource.FromResource("Trondheimsfjord.Images.bell.png")
            };
            alarmBtn.SetBinding(Image.SourceProperty, new Binding("AlarmImageSource"));

            View = new StackLayout
            {
                Padding = new Thickness(10, 5, 30, 5),
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                Children = { timeLabel, alarmBtn }
            };
        }
    }
}
