using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    public partial class CoachForm : Form
    {
        private List<CoachTimetable> coachTimetableList;
        private uint coachID;

        public delegate void SaveCoachArgs(Coach coach, Image picture);
        public event SaveCoachArgs SaveCoach;

        /// <summary>
        /// Raises the SaveCoach event safely.
        /// </summary>
        private void RaiseSaveCoachEvent(Coach coach, Image picture)
        {
            if(SaveCoach != null)
            {
                SaveCoach(coach, picture);
            }
        }

        /// <summary>
        /// Sets the data to the controls of the form.
        /// </summary>
        private void FIllInformation(Coach coach, Image picture)
        {
            inputInformation.SetNameTextBox(coach.Name);
            inputInformation.SetSurnameTextBox(coach.Surname);
            inputInformation.SetDOBdateTimePicker(coach.DateOfBirth);
            inputInformation.SetPhoneNumUpDown(coach.PhoneNumber);
            inputInformation.SetHomeNumUpDown(coach.HomePhoneNumber);
            inputInformation.SetHomeAddressTextBox(coach.HomeAddress);
            inputInformation.SetEmailTextBox(coach.Email);
            inputInformation.SetGenderRadioButton(coach.Gender);

            hourlyPaymentRateNumUpDown.Value = (decimal)coach.HourlyPaymentRate;
            extraHourlyPaymentRateNumUpDown.Value = (decimal)coach.ExtraHourlyPaymentRate;

            for (int i = 0; i < coachTimetableList.Count; i++)
            {
                int lessonNum = i + 1;
                lessonsListBox.Items.Add("Lesson " + lessonNum.ToString());
            }

            if (picture != null)
                searchPicture.MainPictureBoxImage = picture;
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.CoachForm class.
        /// </summary>
        public CoachForm(uint coachIdToBeAssigned)
        {
            this.coachTimetableList = new List<CoachTimetable>();
            this.coachID = coachIdToBeAssigned;
            InitializeComponent();
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.CoachForm class.
        /// </summary>
        public CoachForm(Coach coach, Image picture)
        {
            if (coach.TennisPlayerInfo.TimetableList != null)
                this.coachTimetableList = coach.TennisPlayerInfo.TimetableList;
            else
                this.coachTimetableList = new List<CoachTimetable>();


            this.coachID = coach.ID;
            InitializeComponent();
            FIllInformation(coach, picture);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(inputInformation.SetupInformation())
            {

                Coach coach = new Coach(coachID, inputInformation.PersonInfo.Name, inputInformation.PersonInfo.Surname,
                    inputInformation.PersonInfo.Gender, inputInformation.PersonInfo.Email, inputInformation.PersonInfo.PhoneNumber, inputInformation.PersonInfo.HomePhoneNumber,
                    inputInformation.PersonInfo.HomeAddress, inputInformation.PersonInfo.DateOfBirth, (float)Math.Round(hourlyPaymentRateNumUpDown.Value, 2),
                    (float)Math.Round(extraHourlyPaymentRateNumUpDown.Value, 2), coachTimetableList);

                RaiseSaveCoachEvent(coach, searchPicture.MainPictureBoxImage);

                this.Close();
            }
            else
            {
                MessageBox.Show("Not all the fields have been completed correctly.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTimetableButton_Click(object sender, EventArgs e)
        {
            TimetableInputForm timetableInputForm = new TimetableInputForm(PersonType.Coach);
            timetableInputForm.SaveCoachTimetable += timetableInputForm_SaveNewCoachTimetable;
            timetableInputForm.ShowDialog();

            if (!timetableInputForm.IsDisposed)
                timetableInputForm.Dispose();
        }

        private void timetableInputForm_SaveNewCoachTimetable(CoachTimetable coachTimetable)
        {
            coachTimetableList.Add(coachTimetable);
            lessonsListBox.Items.Add("Lesson " + coachTimetableList.Count.ToString());
        }

        private void lessonsListBox_MouseUp(object sender, MouseEventArgs e)
        {
            lessonsListBox.SelectedIndex = lessonsListBox.IndexFromPoint(e.X, e.Y);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (lessonsListBox.Items.Count > 0 && lessonsListBox.SelectedIndex != -1)
                    lessonContextMenuStrip.Show(MousePosition);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableInputForm timetableForm = new TimetableInputForm(coachTimetableList[lessonsListBox.SelectedIndex]);
            timetableForm.SaveCoachTimetable += timetableForm_SaveExistingCoachTimetable;
            timetableForm.ShowDialog();

            if (!timetableForm.IsDisposed)
                timetableForm.Dispose();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coachTimetableList.RemoveAt(lessonsListBox.SelectedIndex);
            lessonsListBox.Items.RemoveAt(lessonsListBox.SelectedIndex);
        }

        private void timetableForm_SaveExistingCoachTimetable(CoachTimetable coachTimetable)
        {
            coachTimetableList[lessonsListBox.SelectedIndex] = coachTimetable;
        }
    }
}
