using Xamarin.Forms;

namespace Trondheimsfjord.ViewCells
{
    public class DepartureCell : ViewCell
    {
        public DepartureCell()
        {
            var timeLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Accent
            };
            timeLabel.SetBinding(Label.TextProperty, "DepartureTimeString");

            var alarmBtn = new Button
            {
                HorizontalOptions = LayoutOptions.End
            };
            alarmBtn.SetBinding(Button.TextProperty, new Binding("DepartureTimeString"));

            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { timeLabel, alarmBtn }
            };
        }
    }
}
