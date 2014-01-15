using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OBS_Timer
{
    public static class DateTime_Extensions
    {
        // Fix for missing methods in basic objects

        public static DateTime Truncate(this DateTime dateTime, TimeSpan timeSpan)
        {
            return dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));
        }

        public static DateTime TruncateSeconds(this DateTime dateTime)
        {
            return dateTime.Truncate(TimeSpan.FromSeconds(1));
        }

        public static DateTime TruncateMinutes(this DateTime dateTime)
        {
            return dateTime.Truncate(TimeSpan.FromMinutes(1));
        }


        public static DateTime SubtractMinutes(this DateTime dateTime, long minutes)
        {
            return dateTime.AddMinutes(minutes * -1);
        }

        
    }
}
