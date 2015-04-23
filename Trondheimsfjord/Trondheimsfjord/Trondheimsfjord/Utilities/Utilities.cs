using System;

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
    }
}
