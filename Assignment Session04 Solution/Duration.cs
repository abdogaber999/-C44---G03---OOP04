using System;

namespace Assignment_Session04_Solution
{
    public class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        // Constructor: total seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Methods
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        // Convert to total seconds
        private int ToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        // Override ToString()
        public override string ToString()
        {
            if (Hours == 0 && Minutes > 0 && Seconds > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        // Override Equals()
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return ToSeconds() == other.ToSeconds();
            return false;
        }

        // Override GetHashCode()
        public override int GetHashCode()
        {
            return HashCode.Combine(ToSeconds());
        }
        #endregion

        #region Operators
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() + d2.ToSeconds());
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.ToSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.ToSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Max(0, d1.ToSeconds() - d2.ToSeconds()));
        }

        // ++ (يزود دقيقة = 60 ثانية)
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToSeconds() + 60);
        }

        // -- (يقلل دقيقة = 60 ثانية)
        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(0, d.ToSeconds() - 60));
        }

        // Comparison Operators
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() >= d2.ToSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }

        // True / False Operators (for if(D1))
        public static bool operator true(Duration d)
        {
            return d.ToSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToSeconds() == 0;
        }

        // explicit: Duration → DateTime
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddSeconds(d.ToSeconds());
        }
        #endregion
    }
}
