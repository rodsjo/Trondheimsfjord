using System;

namespace Trondheimsfjord.Models
{
    public class Departure
    {
        public Port Port { get; set; }
        public DayOfWeek Weekday { get; set; }
        public DateTime Time { get; set; }
    }
}
