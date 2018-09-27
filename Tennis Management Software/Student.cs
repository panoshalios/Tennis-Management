using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    [Serializable]
    public sealed class Student : Person, ITennisPlayer<StudentTimetable>, IClient
    {
        public enum StudentSkillLevel 
        {
            NewStudent,
            HalfBall,
            OneBall,
            TwoBalls,
            OneRacquet,
            OneRacquetOneBall,
            OneRacquetTwoBalls,
            TwoRacquets,
            TwoRacquetsOneBall,
            TwoRacquetsTwoBalls,
            OneStar,
            TwoStars,
            ThreeStars,
            FourStars,
            FiveStars 
        }

        public TennisPlayerInformation<StudentTimetable> TennisPlayerInfo { get; set; } //3015 bytes
        public StudentSkillLevel StudentLevel { get; set; } //4 bytes
        public string FatherName { get; set; } //50chars * 2bytes = 100bytes
        public string MotherName { get; set; } //50chars * 2bytes = 100bytes
        public string FatherPhoneNumber { get; set; } //10chars * 2bytes = 20bytes
        public string MotherPhoneNumber { get; set; } //10chars * 2bytes = 20bytes
        public uint TennisAssociationNum { get; set; } //8 bytes
        public uint HealthCertificateNum { get; set; } //8 bytes
      

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.Student class.
        /// </summary>
        public Student()
        {
            Initialise();
            this.TennisPlayerInfo = new TennisPlayerInformation<StudentTimetable>();
            this.StudentLevel = StudentSkillLevel.NewStudent;
            this.FatherName = string.Empty;
            this.MotherName = string.Empty;
            this.FatherPhoneNumber = "";
            this.MotherPhoneNumber = "";
            this.TennisAssociationNum = 0;
            this.HealthCertificateNum = 0;
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.Student class.
        /// </summary>
        public Student(uint id, string name, string surname, PersonGender gender,
            string phoneNumber, string homePhoneNumber, string homeAddress, 
            DateTime dateOfBirth, string email, StudentSkillLevel studentLevel, 
            List<StudentTimetable> studentTimetableList, string fatherWorkAddress, 
            string motherWorkAddress, string fatherPhoneNumber, string motherPhoneNumber,
            uint studentTennisAssociationNum, uint healthCertificateNum)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.HomePhoneNumber = homePhoneNumber;
            this.HomeAddress = homeAddress;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.StudentLevel = studentLevel;
            this.FatherName = fatherWorkAddress;
            this.MotherName = motherWorkAddress;
            this.FatherPhoneNumber = fatherPhoneNumber;
            this.MotherPhoneNumber = motherPhoneNumber;
            this.TennisAssociationNum = studentTennisAssociationNum;
            this.HealthCertificateNum = healthCertificateNum;
            TennisPlayerInfo = new TennisPlayerInformation<StudentTimetable>(studentTimetableList);
        }

        /// <summary>
        /// Returns the StudentSkillLevel of the Student as a string.
        /// </summary>
        /// <returns></returns>
        public string GetStudentLevel()
        {
            switch (this.StudentLevel)
            {
                case StudentSkillLevel.NewStudent:
                    return "New student";
                case StudentSkillLevel.HalfBall:
                    return "Half ball";
                case StudentSkillLevel.OneBall:
                    return "One ball";
                case StudentSkillLevel.TwoBalls:
                    return "Two balls";
                case StudentSkillLevel.OneRacquet:
                    return "One racquet";
                case StudentSkillLevel.OneRacquetOneBall:
                    return "One racquet, one ball";
                case StudentSkillLevel.OneRacquetTwoBalls:
                    return "One racquet, two balls";
                case StudentSkillLevel.TwoRacquets:
                    return "Two racquets";
                case StudentSkillLevel.TwoRacquetsOneBall:
                    return "Two racquets one ball";
                case StudentSkillLevel.TwoRacquetsTwoBalls:
                    return "Two racquets two balls";
                case StudentSkillLevel.OneStar:
                    return "One star";
                case StudentSkillLevel.TwoStars:
                    return "Two stars";
                case StudentSkillLevel.ThreeStars:
                    return "Three stars";
                case StudentSkillLevel.FourStars:
                    return "Four stars";
                case StudentSkillLevel.FiveStars:
                    return "Five stars";
            }
            return null;
        }

        /// <summary>
        /// Calculates the money that the Student pays for private lessons.
        /// </summary>
        /// <param name="privateLessonFee">The fees for private lessons.</param>
        /// <returns></returns>
        public float GetMoneyPayingForPrivateLessons(float privateLessonFee)
        {
            float payingMoney = privateLessonFee * TennisPlayerInfo.NumOfPrivateLessonsPerWeek;
            return payingMoney;
        }

        /// <summary>
        /// Calculates the money that the Student pays for group lessons.
        /// </summary>
        /// <param name="groupLessonFee">The fees for group lessons.</param>
        /// <returns></returns>
        public float GetMoneyPayingForGroupLessons(float groupLessonFee)
        {
            float payingMoney = groupLessonFee * TennisPlayerInfo.NumOfGroupLessonsPerWeek;
            return payingMoney;
        }

        /// <summary>
        /// Calculates the money that the Student pays for semi-private lessons.
        /// </summary>
        /// <param name="semiPrivateLessonFee">The fees for semi-private lessons.</param>
        /// <returns></returns>
        public float GetMoneyPayingForSemiPrivateLessons(float semiPrivateLessonFee)
        {
            float payingMoney = semiPrivateLessonFee * TennisPlayerInfo.NumOfSemiPrivateLessonsPerWeek;
            return payingMoney;
        }

        /// <summary>
        /// Calculates the money that the Student pays for all the lessons.
        /// </summary>
        /// <param name="privateLessonFee">The fees for private lessons.</param>
        /// <param name="groupLessonFee">The fees for group lessons.</param>
        /// <param name="semiPrivateLessonFee">The fees for semi-private lessons.</param>
        /// <returns></returns>
        public float GetTotalPayingMoney(float privateLessonFee, float groupLessonFee, float semiPrivateLessonFee)
        {
            float[] payingMoney = new float[3];
            payingMoney[0] = GetMoneyPayingForGroupLessons(groupLessonFee);
            payingMoney[1] = GetMoneyPayingForPrivateLessons(privateLessonFee);
            payingMoney[2] = GetMoneyPayingForSemiPrivateLessons(semiPrivateLessonFee);

            return payingMoney.Sum();
        }

        /// <summary>
        /// Returns all the information about the Student except the ID as a string. 
        /// </summary>
        /// <param name="privateLessonFee">The fees for private lessons.</param>
        /// <param name="groupLessonFee">The fees for group lessons.</param>
        /// <param name="semiPrivateLessonFee">The fees for semi-private lessons.</param>
        /// <returns></returns>
        public string GetAllInformation(float privateLessonFee, float groupLessonFee, float semiPrivateLessonFee)
        {
            return base.GetAllInformation() + "\nFather name: " + FatherName + "\nMother name: " + MotherName + "\nFather phone number: " + FatherPhoneNumber + "\nMother phone number: " + MotherPhoneNumber + "\nHealth certificate number: " + HealthCertificateNum + "\nTennis association number: " + TennisAssociationNum + "\nStudent level: " + GetStudentLevel() + "\nNumber of group lessons each week: " + TennisPlayerInfo.NumOfGroupLessonsPerWeek + "\nNumber of private lessons each week: " + TennisPlayerInfo.NumOfPrivateLessonsPerWeek + "\nNumber of semi-private lessons each week: " + TennisPlayerInfo.NumOfSemiPrivateLessonsPerWeek + "\nTime in court each week: " + TennisPlayerInfo.TimeInCourtPerWeek.GetTotalTime() + "\nTime in court this month: " + TennisPlayerInfo.GetTimeInCourtThisMonth().GetTotalTime() + "\nMoney paying for group lessons: " + EuroSign + GetMoneyPayingForGroupLessons(groupLessonFee) + "\nMoney paying for private lessons: " + GetMoneyPayingForPrivateLessons(privateLessonFee) + "\nMoney paying for semi-private lessons: " + EuroSign + GetMoneyPayingForSemiPrivateLessons(semiPrivateLessonFee) + "\nTotal money paying for lessons: " + EuroSign + GetTotalPayingMoney(privateLessonFee, groupLessonFee, semiPrivateLessonFee);
        }
    }
    //3275 bytes + 341 PersonBytes = 3616 total bytes
}
