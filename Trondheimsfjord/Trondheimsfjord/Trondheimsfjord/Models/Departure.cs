using System;

namespace Trondheimsfjord.Models
{
    public class Departure
    {
        public Port Port { get; set; }
        public Destination Destination { get; set; }
        public DayOfWeek Weekday { get; set; }

        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
    }

    public enum Destination
    {
        Trondheim,
        Brekstad,
        Edøy,
        Kristiansund,
        Vanvikan
    }
}
