using System;

namespace Utils
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime? Validate(this DateTime? dt)
        {
            // some dates seem to be set as 1900 if they are empty
            // other 1753
            // handle them both like this. 

            DateTime d = dt.GetValueOrDefault();

            if (d.Year < 1990)
                return null;

            return d;
        }

        public static DateTime? Correct1918(this DateTime? dt)
        {
            // some dates seem to be set as 1900 if they are empty
            // other 1753
            // handle them both like this. 

            DateTime d = dt.GetValueOrDefault();

            if (d.Year < 1919)
                return null;

            return d;
        }

        public static DateTime? Validate(this DateTime dt)
        {
            // some dates seem to be set as 1900 if they are empty
            // other 1753
            // handle them both like this. 

            DateTime d = dt;

            if (d.Year < 1990)
                return null;

            return d;
        }
        public static DateTime? ToNullable(this DateTime dt)
        {
          
            DateTime? d = dt;

        

            return d;
        }


    }
}