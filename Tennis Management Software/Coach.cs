using System;
using System.Collections.Generic;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    [Serializable]
    public sealed class Coach : Person, ITennisPlayer<CoachTimetable>
    {
        public TennisPlayerInformation<CoachTimetable> TennisPlayerInfo { get; set; } //3015 bytes
        public float HourlyPaymentRate { get; set; } // 4 bytes
        public float ExtraHourlyPaymentRate { get; set; } // 4 bytes

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Coach class.
        /// </summary>
        public Coach() 
        {
            Initialise();
            HourlyPaymentRate = 0;
            ExtraHourlyPaymentRate = 0;
            TennisPlayerInfo = new TennisPlayerInformation<CoachTimetable>();
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Coach class.
        /// </summary>
        public Coach(uint id, string name, string surname, PersonGender gender, string email,
            string phoneNumber, string homePhoneNumber, string homeAddress, DateTime dateOfBirth, 
            float hourlyPaymentRate, float extraHourlyPaymentRate, List<CoachTimetable> timetableList)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.HomePhoneNumber = homePhoneNumber;
            this.HomeAddress = homeAddress;
            this.DateOfBirth = dateOfBirth;
            this.HourlyPaymentRate = hourlyPaymentRate;
            this.ExtraHourlyPaymentRate = extraHourlyPaymentRate;
            TennisPlayerInfo = new TennisPlayerInformation<CoachTimetable>(timetableList);
        }


        /// <summary>
        /// Returns the money the Coach needs to get paid this current month.
        /// </summary>
        /// <returns></returns>
        public float GetMoneyPaidThisMonth()
        {
            float moneyPaid = HourlyPaymentRate * TennisPlayerInfo.GetTimeInCourtThisMonth().Hours;
            return moneyPaid;
        }

        /// <summary>
        /// Returns all the information about the Coach.
        /// </summary>
        /// <returns></returns>
        public new string GetAllInformation()
        {
            return base.GetAllInformation() + "\nHourly payment rate: " + EuroSign + this.HourlyPaymentRate + "\nExtra hourly payment rate: " + EuroSign + this.ExtraHourlyPaymentRate + "\nNumber of private lessons: " + TennisPlayerInfo.NumOfPrivateLessonsPerWeek + "\nNumber of group lessons: " + TennisPlayerInfo.NumOfGroupLessonsPerWeek + "\nNumber of semi-private lessons: " + TennisPlayerInfo.NumOfSemiPrivateLessonsPerWeek  + "\nTime working per week: " + TennisPlayerInfo.TimeInCourtPerWeek.GetTotalTime() + "\nTime working this month: " + TennisPlayerInfo.GetTimeInCourtThisMonth().GetTotalTime() + "\nMoney paid this month: " + EuroSign + GetMoneyPaidThisMonth();
        }
    }
    // 3023 bytes + 341 PersonBytes = 3364 bytes total
}