using System;

namespace Trondheimsfjord.Utilities
{
    public class Utilities
    {
        public static string NiceTime(TimeSpan time)
        {
            if (time.Minutes == 0) //Only hours
            {
                if (time.Hours == 1)
                    return "1 time";
                return time.Hours + " timer";
            }
            if (time.Hours == 0) //Only minutes
            {
                if (time.Minutes == 1)
                    return "1 minutt";
                return time.Hours + " minutter";
            }

            //If we have both hours and minutes
            var s = time.Hours.ToString();
            s += time.Hours == 1 ? " time og " : " timer og ";

            s += time.Minutes.ToString();
            s += time.Minutes == 1 ? " minutt" : " minutter";

            return s;
        }
    }
}
