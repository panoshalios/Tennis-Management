using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.Timetabling
{
    [Serializable]
    public class StudentTimetable : Timetable
    {
        public string CoachName { get; set; } //40chars * 2bytes = 80bytes

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Timetabling.StudentTimetable class.
        /// </summary>
        public StudentTimetable(DayOfWeek day, Time fromTime, Time toTime,
            byte tennisCourtNum, List<string> studentNamesInGroup, string coachName, LessonType typeOfLesson)
        {
            this.Day = day;
            this.FromTime = fromTime;
            this.ToTime = toTime;
            this.StudentsNamesInGroup = studentNamesInGroup;
            this.TennisCourtNum = tennisCourtNum;
            this.CoachName = coachName;
            this.TypeOfLesson = typeOfLesson;
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Timetabling.StudentTimetable class.
        /// </summary>
        public StudentTimetable(DayOfWeek day, Time fromTime, Time toTime,
            byte tennisCourtNum, string coachName, LessonType typeOfLesson)
        {
            this.Day = day;
            this.FromTime = fromTime;
            this.ToTime = toTime;
            this.TennisCourtNum = tennisCourtNum;
            this.CoachName = coachName;
            this.TypeOfLesson = typeOfLesson;
        }
    }
    // 679 bytes total
}
