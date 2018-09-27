using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Management_Software
{
    public partial class InputInformation : UserControl
    {
        public Person PersonInfo;

        public void SetNameTextBox(string name)
        {
            nameTbox.Text = name;
        }

        public void SetSurnameTextBox(string surname)
        {
            surnameTbox.Text = surname;
        }

        public void SetDOBdateTimePicker(DateTime dob)
        {
            dateTimePicker.Value = dob;
        }

        public void SetPhoneNumUpDown(string phoneNum)
        {
            phoneNumericUpDown.Value = Convert.ToDecimal(phoneNum);
        }

        public void SetHomeNumUpDown(string phoneNum)
        {
            homePhoneNumericUpDown.Value = Convert.ToDecimal(phoneNum);
        }

        public void SetHomeAddressTextBox(string homeAddress)
        {
            homeAddressTbox.Text = homeAddress;
        }

        public void SetEmailTextBox(string email)
        {
            emailTbox.Text = email;
        }

        public void SetGenderRadioButton(Person.PersonGender personGender)
        {
            switch (personGender)
            {
                case Person.PersonGender.Male:
                    maleRadioButton.Checked = true;
                    break;
                case Person.PersonGender.Female:
                    femaleRadioButton.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Checks if the field of the user control are completed correctly.
        /// </summary>
        /// <returns></returns>
        private bool AreFieldsComplete()
        {
            bool fieldsComplete = true;
            const int minimumCharLength = 3;
            const int minimumPhoneNumberLength = 8;

            //For the Name
            if (nameTbox.Text.Length < minimumCharLength || nameTbox.Text.Any(char.IsDigit))
            {
                nameTbox.Text = "";
                nameLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                nameLabel.ForeColor = Color.Black;
            }

            //For the Surname
            if (surnameTbox.Text.Length < minimumCharLength || surnameTbox.Text.Any(char.IsDigit))
            {
                surnameTbox.Text = "";
                surnameLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                surnameLabel.ForeColor = Color.Black;
            }

            //For the phone number
            if(phoneNumericUpDown.Value.ToString().Length < minimumPhoneNumberLength)
            {
                phoneLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                phoneLabel.ForeColor = Color.Black;
            }

            //For the Home phone number
            if (homePhoneNumericUpDown.Value.ToString().Length < minimumPhoneNumberLength)
            {
                homePhoneLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                homePhoneLabel.ForeColor = Color.Black;
            }

            //For the Home address
            if (homeAddressTbox.Text.Length < minimumCharLength)
            {
                homeAddressTbox.Text = "";
                homeAddressLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                homeAddressLabel.ForeColor = Color.Black;
            }

            //For the Email
            if (emailTbox.Text.Length < minimumCharLength)
            {
                emailTbox.Text = "";
                emailLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                emailLabel.ForeColor = Color.Black;
            }

            //For the date of birth
            if(dateTimePicker.Value > DateTime.Today)
            {
                dateTimePicker.Value = DateTime.Today;
                dobLabel.ForeColor = Color.Red;
                fieldsComplete = false;
            }
            else
            {
                dobLabel.ForeColor = Color.Black;
            }

            return fieldsComplete;
        }

        /// <summary>
        /// Corrects the formats of the strings.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static string CorrectInputFormat(string strValue)
        {
            if (strValue.Length == 0)
                return strValue;

            StringBuilder result = new StringBuilder(strValue);
            result[0] = char.ToUpper(strValue[0]);

            for (int i = 1; i < strValue.Length; i++ )
            {
                if (char.IsWhiteSpace(strValue[i - 1]))
                    result[i] = char.ToUpper(strValue[i]);
                else
                    result[i] = char.ToLower(strValue[i]);
            }

                return result.ToString();
        }

        /// <summary>
        /// Sets up all the information so that they can be collected after and displays visually which fields have not been entered correctly.
        /// </summary>
        /// <returns></returns>
        public bool SetupInformation()
        {
            if (AreFieldsComplete() == true)
            {
                PersonInfo = new Person();
                if (maleRadioButton.Checked)
                    this.PersonInfo.Gender = Person.PersonGender.Male;
                else
                    this.PersonInfo.Gender = Person.PersonGender.Female;

                this.PersonInfo.Name = CorrectInputFormat(nameTbox.Text);
                this.PersonInfo.Surname = CorrectInputFormat(surnameTbox.Text);
                this.PersonInfo.DateOfBirth = dateTimePicker.Value;
                this.PersonInfo.PhoneNumber = phoneNumericUpDown.Value.ToString();
                this.PersonInfo.HomePhoneNumber = homePhoneNumericUpDown.Value.ToString();
                this.PersonInfo.HomeAddress = CorrectInputFormat(homeAddressTbox.Text);
                this.PersonInfo.Email = emailTbox.Text.ToLower();

                return true;
            }
            return false;
        }

        public InputInformation()
        {
            InitializeComponent();
        }
    }
}
