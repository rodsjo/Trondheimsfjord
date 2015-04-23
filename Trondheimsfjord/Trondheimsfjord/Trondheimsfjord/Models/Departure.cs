using System;

namespace Trondheimsfjord.Models
{
    public class Departure
    {
        public Port Port { get; set; }
        public Destination Destination { get; set; }
        public DayOfWeek Weekday { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }

    public enum Destination
    {
        Trondheim,
        Brekstad,
        Edøy,
        Kristiansund
    }
}
