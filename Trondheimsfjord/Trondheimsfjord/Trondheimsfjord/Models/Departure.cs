using System;

namespace Trondheimsfjord.Models
{
    public class Departure
    {
        public Port From { get; set; }
        public Port To { get; set; }
        public DayOfWeek Weekday { get; set; }

        public Departure()
        {
            AlarmOn = false;
        }

        public bool AlarmOn { get; set; }
        public TimeSpan DepartureTime { get; set; }

        public string AlarmImageSource
        {
            get { return AlarmOn ? "Trondheimsfjord.Images.bell_blue.png" : "Trondheimsfjord.Images.bell.png"; }
        }

        public string DepartureTimeString
        {
            get { return Utilities.Utilities.HourAndMinuteTime(DepartureTime); }
        }

        public TimeSpan ArrivalTime { get; set; }
    }
}
