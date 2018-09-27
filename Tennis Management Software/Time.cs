using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software
{
    [Serializable]
    public sealed class Time
    {
        public int Hours { get; set; } //4 bytes
        public int Minutes { get; set; } //4 bytes

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Time class.
        /// </summary>
        public Time()
        {
            Hours = 0;
            Minutes = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Time class.
        /// </summary>
        /// <param name="hours">The hours to be set.</param>
        /// <param name="minutes">The minutes to be set.</param>
        public Time(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        /// <summary>
        /// Returns a value indicating if the calling object is greater or smaller that the specified object.
        /// </summary>
        /// <param name="time">The Time object to compare.</param>
        /// <returns></returns>
        public bool GreaterThan(Time time)
        {
            if (time == null)
                return true;
            //Greater than the parameter
            if (this.Hours > time.Hours)
                return true;
            //Greater than the parameter
            if (this.Hours == time.Hours && this.Minutes > time.Minutes)
                return true;

            //Smaller than the parameter
            return false;
        }

        /// <summary>
        /// Returns the Time as a string in the format Hours:Minutes AM/PM.
        /// </summary>
        /// <returns></returns>
        public string GetTime()
        {
            string minutes = Minutes.ToString();

            if (Minutes < 10)
                minutes = "0" + Minutes.ToString();

            if (Hours > 12)
                return (Hours - 12 + ":" + minutes + " PM").ToString();
            else
                return (Hours + ":" + minutes + " AM").ToString();
        }

        /// <summary>
        /// Returns the total time as a string in the format Hours:var Minutes:var
        /// </summary>
        /// <returns></returns>
        public string GetTotalTime()
        {
            return "Hours: " + this.Hours.ToString() + " Minutes: " + this.Minutes.ToString();
        }
        
    }
    // 8 bytes total
}
