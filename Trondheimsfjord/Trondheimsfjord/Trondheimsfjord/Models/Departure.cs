using System;

namespace Trondheimsfjord.Models
{
    public class Departure
    {
        public Port From { get; set; }
        public Port To { get; set; }
        public DayOfWeek Weekday { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public string DepartureTimeString
        {
            get { return Utilities.Utilities.HourAndMinuteTime(DepartureTime); }
        }

        public TimeSpan ArrivalTime { get; set; }
    }
}
