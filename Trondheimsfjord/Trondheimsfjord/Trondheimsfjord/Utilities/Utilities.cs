using System;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Utilities
{
    public class Utilities
    {
        public static string NiceTime(TimeSpan time)
        {
            var now = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            var delta = time.Subtract(now);

            if (delta.Minutes == 0) //Only hours
            {
                if (delta.Hours == 1)
                    return "1 time";
                return delta.Hours + " timer";
            }
            if (delta.Hours == 0) //Only minutes
            {
                if (delta.Minutes == 1)
                    return "1 minutt";
                return delta.Minutes + " minutter";
            }

            //If we have both hours and minutes
            var s = delta.Hours.ToString();
            s += delta.Hours == 1 ? " time og " : " timer og ";

            s += delta.Minutes.ToString();
            s += delta.Minutes == 1 ? " minutt" : " minutter";

            return s;
        }

        public static string GetRouteTableWeekdayTitle(Route route)
        {
            if (route.AtBRouteNr == 810)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    return "Lørdag";
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    return "Søndag";
                }
                return "Mandag - fredag";
            }
            if (route.AtBRouteNr == 800)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    return "Lørdag";
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    return "Søndag";
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                {
                    return "Fredag";
                }
                return "Mandag - torsdag";
            }
            return "";
        }

        internal static string HourAndMinuteTime(TimeSpan timeSpan)
        {
            string time;
            if (timeSpan.Hours < 10)
            {
                time = "0" + timeSpan.Hours;
            }
            else
            {
                time = timeSpan.Hours.ToString();
            }
            time += ":";
            if (timeSpan.Minutes < 10)
            {
                time += "0" + timeSpan.Minutes;
            }
            else
            {
                time += timeSpan.Minutes;
            }
            return time;
        }
    }
}
