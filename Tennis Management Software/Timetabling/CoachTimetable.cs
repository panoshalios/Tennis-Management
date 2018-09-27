using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.Timetabling
{
    [Serializable]
    public class CoachTimetable : Timetable
    {
        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Timetabling.CoachTimetable class.
        /// </summary>
        public CoachTimetable(DayOfWeek day, Time fromTime, Time toTime, 
             byte tennisCourtNum, List<string> studentNamesInGroup, LessonType typeOfLesson)
        {
            this.Day = day;
            this.FromTime = fromTime;
            this.ToTime = toTime;
            this.TennisCourtNum = tennisCourtNum;
            this.StudentsNamesInGroup = studentNamesInGroup;
            this.TypeOfLesson = typeOfLesson;
        }
    }
    //599 bytes total
}
