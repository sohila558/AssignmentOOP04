using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.First_Project
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }

        public int ToTotalSeconds()
        {
            return (Hours * 3600) + (Minutes * 60) + Seconds;
        }

        public static Duration operator +(Duration D1, Duration D2)
        {
            int newTime = D1.ToTotalSeconds() + D2.ToTotalSeconds();
            return new Duration(newTime);
        }

        public static Duration operator -(Duration D1, Duration D2)
        {
            int newTime = D1.ToTotalSeconds() - D2.ToTotalSeconds();
            if (newTime < 0) newTime = 0;
            return new Duration(newTime);
        }

        public static Duration operator +(Duration D, int seconds)
        {
            int newTime = D.ToTotalSeconds() + seconds;
            return new Duration(newTime);
        }

        public static Duration operator +(int seconds, Duration D)
        {
            int newTime = D.ToTotalSeconds() + seconds;
            return new Duration(newTime);
        }

        public static Duration operator ++(Duration D)
        {
            int newTime = D.ToTotalSeconds() + 60; 
            return new Duration(newTime);
        }

        public static Duration operator --(Duration D)
        {
            int newTime = D.ToTotalSeconds() - 60; 
            if (newTime < 0) newTime = 0;
            return new Duration(newTime);
        }

        public static bool operator >(Duration D1, Duration D2)
        {
            return D1.ToTotalSeconds() > D2.ToTotalSeconds();
        }

        public static bool operator <(Duration D1, Duration D2)
        {
            return D1.ToTotalSeconds() < D2.ToTotalSeconds();
        }
        public override string ToString()
        {
            string time = "";
            if (Hours > 0)
            {
                time += $"Hours : {Hours}, ";
            }

            if(Minutes > 0)
            {
                time += $"Minutes : {Minutes}, ";
            }
            else
            {
                time += "Minutes : 0, ";
            }

            time += $"Seconds : {Seconds}";

            return time;
        }


    }
}
