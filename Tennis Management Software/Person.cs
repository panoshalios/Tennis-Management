using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tennis_Management_Software
{
    [Serializable]
    public class Person
    {
        public enum PersonGender 
        { 
            Male, 
            Female 
        };


        //ID is basically the index which the person will be held in the list.
        public uint ID { get; set; } // 8 bytes
        public string Name { get; set; } // 20chars * 2bytes = 40 bytes
        public string Surname { get; set; } // 20chars * 2bytes = 40 bytes
        public PersonGender Gender { get; set; } // 4 bytes
        public string PhoneNumber { get; set; } //10chars * 2bytes = 20bytes
        public string HomePhoneNumber { get; set; } //10chars * 2bytes = 20bytes
        public string HomeAddress { get; set; } // 50chars * 2bytes = 100 bytes
        public string Email { get; set; } // 50chars * 2bytes = 100 bytes

        private byte age; // 1 byte
        public byte Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }

        private DateTime dateOfBirth; // 8 bytes
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
                this.age = GetAge(value);
            }
        }

        [NonSerialized]
        protected const string EuroSign = "\u20AC";

        /// <summary>
        /// Returns the full name of the person.
        /// </summary>
        public string FullName { get { return Name + " " + Surname; } }

        /// <summary>
        /// Returns the full name of the person plus their unique ID.
        /// </summary>
        public string FullNameAndID { get { return FullName + "_" + ID.ToString(); } }

        /// <summary>
        /// Returns the gender of the person in string format.
        /// </summary>
        public string GetGender()
        {
            if (this.Gender == PersonGender.Male)
                return "Male";
            else
                return "Female";
        }

        protected void Initialise()
        {
            this.ID = 0;
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.age = 0;
            this.Gender = PersonGender.Male;
            this.PhoneNumber = "";
            this.HomePhoneNumber = "";
            this.dateOfBirth = new DateTime();
            this.HomeAddress = string.Empty;
            this.Email = string.Empty;
        }

        /// <summary>
        /// Calculates the age of the person.
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns>The age of the person</returns>
        private byte GetAge(DateTime dateOfBirth)
        {
            if (DateTime.Today.Month > dateOfBirth.Month || (DateTime.Today.Month == dateOfBirth.Month
                && DateTime.Today.Day >= dateOfBirth.Day))
                return (byte)(DateTime.Today.Year - dateOfBirth.Year);
            else
                return (byte)(DateTime.Today.Year - dateOfBirth.Year - 1);
        }

        /// <summary>
        /// Gets all the information about the Tennis_Management_Software.Person except their ID.
        /// </summary>
        /// <returns></returns>
        protected string GetAllInformation()
        {
            string _dateOfBirth = DateOfBirth.Day.ToString() + "/" + DateOfBirth.Month.ToString() + "/" + DateOfBirth.Year.ToString();
            string information = "Name: " + Name + "\nSurname: " + Surname + "\nAge: " + Age.ToString() + "\nDate of birth: " + _dateOfBirth + "\nGender: " + GetGender() + "\nPhone number: " + PhoneNumber.ToString() + "\nHome phone number: " + HomePhoneNumber.ToString() + "\nHome address: " + HomeAddress + "\nE-mail: " + Email;
            return information;
        }

    }
    //341 bytes total

    public enum PersonType
    {
        Student,
        Coach
    };
}
