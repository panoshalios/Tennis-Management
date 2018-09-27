using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Management_Software.Timetabling
{
    [Serializable]
    public class Timetable
    {
        public DayOfWeek Day { get; set; } // 4 bytes
        public Time FromTime { get; set; } // 8 bytes
        public Time ToTime { get; set; } // 8 bytes
        public byte TennisCourtNum { get; set; } // 1 byte
        public LessonType TypeOfLesson { get; set; } // 4 bytes
        public List<string> StudentsNamesInGroup { get; set; } //41 chars each * 2bytes = 82 chars * (example)7 names = 574 bytes
        
        /// <summary>
        /// Returns the type of lesson as a string.
        /// </summary>
        /// <returns></returns>
        public string GetLessonType()
        {
            switch (TypeOfLesson)
            {
                case LessonType.Private:
                    return "Private Lesson";
                case LessonType.Group:
                    return "Group Lesson";
                case LessonType.SemiPrivate:
                    return "Semi-Private Lesson";
                default:
                    return null;
            }
        }
    }
    //599 bytes total

    public enum LessonType
    {
        Private,
        SemiPrivate,
        Group
    }
}
