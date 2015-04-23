using System;
using NUnit.Framework;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Test
{
    [TestFixture]
    public class DatabaseTest
    {
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "0:0", Result = "5:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "5:49", Result = "5:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "5:50", Result = "6:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "5:51", Result = "6:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "12:01", Result = "13:0")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "15:29", Result = "15:30")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "15:30", Result = "16:30")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Monday, "22:56", Result = "5:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Friday, "0:0", Result = "5:50")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Friday, "23:49", Result = "6:30")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Friday, "24:00", Result = "6:30")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Saturday, "12:51", Result = "13:30")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Saturday, "17:45", Result = "10:0")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Sunday, "8:29", Result = "10:0")]
        [TestCase(810, "Vanvikan", "Trondheim", DayOfWeek.Sunday, "22:56", Result = "5:50")]

        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Monday, "0:0", Result = "6:20")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Monday, "7:20", Result = "8:25")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Monday, "23:31", Result = "6:20")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Tuesday, "53452:4256243", Result = "6:20")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Friday, "24:00", Result = "7:25")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Saturday, "16:51", Result = "17:0")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Saturday, "19:45", Result = "9:30")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Sunday, "8:29", Result = "9:30")]
        [TestCase(810, "Trondheim", "Vanvikan", DayOfWeek.Sunday, "22:56", Result = "6:20")]
        public string GetNextDeparture_should_return_correct_departure(int atbRouteNr, string fromPort, string toPort, DayOfWeek weekDay, string time)
        {
            var hourAndMinute = time.Split(new [] {':'});
            var hour = int.Parse(hourAndMinute[0]);
            var minute = int.Parse(hourAndMinute[1]);

            var wantedTime = new TimeSpan(hour, minute, 0);

            var nextDeparture = Database.Database.GetNextDeparture(atbRouteNr, fromPort, toPort, weekDay, wantedTime);
            return nextDeparture.DepartureTime.Hours + ":" + nextDeparture.DepartureTime.Minutes;
        }

        [Test]
        public void GetNextDeparture_should_return_null_if_incorrect_destination()
        {
            var departure = Database.Database.GetNextDeparture(810, "Vanvikan", "Edøy", DayOfWeek.Thursday,
                new TimeSpan(12, 0, 0));
            Assert.IsNull(departure);
        }
    }
}
