using System;
using NUnit.Framework;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Test
{
    [TestFixture]
    public class DatabaseTest
    {
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "0:0", Result = "5:50")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "5:49", Result = "5:50")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "5:50", Result = "6:50")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "5:51", Result = "6:50")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "12:01", Result = "13:0")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "15:29", Result = "15:30")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "15:30", Result = "16:30")]
        [TestCase(810, "Vanvikan", Destination.Trondheim, DayOfWeek.Monday, "22:56", Result = "5:50")]
        public string GetNextDeparture_should_return_correct_departure(int atbRouteNr, string port, Destination destination, DayOfWeek weekDay, string time)
        {
            var hourAndMinute = time.Split(new [] {':'});
            var hour = int.Parse(hourAndMinute[0]);
            var minute = int.Parse(hourAndMinute[1]);

            var wantedTime = new TimeSpan(hour, minute, 0);

            var nextDeparture = Database.Database.GetNextDeparture(atbRouteNr, port, destination, weekDay, wantedTime);
            return nextDeparture.DepartureTime.Hours + ":" + nextDeparture.DepartureTime.Minutes;
        }
    }
}
