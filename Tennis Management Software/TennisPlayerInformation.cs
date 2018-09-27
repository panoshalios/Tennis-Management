using System;
using System.Collections.Generic;
using System.Linq;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    [Serializable]
    public sealed class TennisPlayerInformation<T> where T : Timetable
    {
        private List<T> timetableList; // 5 timetables * 599 = 2995 bytes
        public List<T> TimetableList 
        { 
            get 
            { 
                return timetableList.ToList(); 
            } 
            set 
            { 
                timetableList = value;
                CalculateNumberOfLessons();
                TimeInCourtPerWeek = GetTimeInCourtPerWeek();
            } 
        }

        public int NumOfPrivateLessonsPerWeek { get; private set; } //4 bytes
        public int NumOfGroupLessonsPerWeek { get; private set; }//4 bytes
        public int NumOfSemiPrivateLessonsPerWeek { get; private set; } //4 bytes
        public Time TimeInCourtPerWeek { get; private set; } //8bytes

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.TennisPlayerInformation class.
        /// </summary>
        public TennisPlayerInformation()
        {
            timetableList = new List<T>();
            NumOfPrivateLessonsPerWeek = 0;
            NumOfGroupLessonsPerWeek = 0;
            NumOfSemiPrivateLessonsPerWeek = 0;
            TimeInCourtPerWeek = new Time();
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.TennisPlayerInformation class.
        /// </summary>
        public TennisPlayerInformation(List<T> timetableList)
        {
            this.TimetableList = timetableList;
        }

        /// <summary>
        /// Returns the number of days at which the specified day of the week occurs. 
        /// </summary>
        /// <param name="dayOfWeek">The day of the week to perform the calculation.</param>
        /// <param name="yearMonth">The year and month to perform the calculation.</param>
        /// <returns></returns>
        private static int GetNumberOfDaysInMonth(DayOfWeek dayOfWeek, DateTime yearMonth)
        {
            if (yearMonth == null)
                throw new ArgumentNullException("yearMonth was null");

            int numOfDays = 0;
            int start = 1;

            if (dayOfWeek != yearMonth.DayOfWeek)
            {
                start = -(yearMonth.DayOfWeek - dayOfWeek - 1);
                if (start <= 0)
                {
                    numOfDays = -1;
                }

            }

            int daysInMonth = DateTime.DaysInMonth(yearMonth.Year, yearMonth.Month);

            while (start <= daysInMonth)
            {
                numOfDays++;
                start += 7;
            }

            return numOfDays;
        }

        /// <summary>
        /// Calculates the total number of group, private and semi-private lessons.
        /// </summary>
        private void CalculateNumberOfLessons()
        {
            foreach (var timetable in timetableList)
            {
                switch (timetable.TypeOfLesson)
                {
                    case LessonType.Private:
                        NumOfPrivateLessonsPerWeek++;
                        break;
                    case LessonType.SemiPrivate:
                        NumOfSemiPrivateLessonsPerWeek++;
                        break;
                    case LessonType.Group:
                        NumOfGroupLessonsPerWeek++;
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the time spent in court every week.
        /// </summary>
        /// <returns></returns>
        private Time GetTimeInCourtPerWeek()
        {
            Time hoursWorking = new Time();
            for (int i = 0; i < timetableList.Count; i++)
            {
                int hours = timetableList[i].ToTime.Hours - timetableList[i].FromTime.Hours;
                int minutes = timetableList[i].ToTime.Minutes - timetableList[i].FromTime.Minutes;
                hoursWorking.Hours += hours;
                hoursWorking.Minutes += minutes;
            }
            return hoursWorking;
        }

        /// <summary>
        /// Returns the time spent in court this month.
        /// </summary>
        /// <returns></returns>
        public Time GetTimeInCourtThisMonth()
        {
            //Get number of mondays this month
            //Sort list for the number of mondays
            //If list is empty skip the next step
            //loop through the number of mondays adding the hours working
            //Do so for the rest of the weekdays

            const int daysInWeek = 7;
            Time timeWorking = new Time();

            for (int i = 0; i < daysInWeek; i++)
            {
                int numOfDays = GetNumberOfDaysInMonth((DayOfWeek)i, new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1));

                var sortedList = from timetable in timetableList
                                 where timetable.Day == (DayOfWeek)i
                                 select timetable;

                if (sortedList.ToList().Count == 0)
                    continue;

                int hours = 0;
                int minutes = 0;

                for (int j = 0; j < numOfDays; j++)
                {
                    foreach (var timetable in sortedList)
                    {
                        hours = timetable.ToTime.Hours - timetable.FromTime.Hours;
                        minutes = timetable.ToTime.Minutes - timetable.FromTime.Minutes;

                        timeWorking.Hours += hours;
                        timeWorking.Minutes += minutes;
                    }
                }
            }

            return timeWorking;
        }

    }//3015 bytes total
}
