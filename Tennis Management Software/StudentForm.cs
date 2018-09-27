using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tennis_Management_Software.Timetabling;

namespace Tennis_Management_Software
{
    public partial class StudentForm : Form
    {
        private List<StudentTimetable> studentTimetableList;
        private uint studentID;

        public delegate void SaveStudentArgs(Student student, Image picture);
        public event SaveStudentArgs SaveStudent;

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.StudentForm class.
        /// </summary>
        /// <param name="studentIdToBeAssigned">The unique ID to be assigned to the Student.</param>
        public StudentForm(uint studentIdToBeAssigned)
        {
            this.studentTimetableList = new List<StudentTimetable>();
            this.studentID = studentIdToBeAssigned;
            InitializeComponent();
            this.studentLevelCbox.SelectedIndex = 0;
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.StudentForm class and fills the information in the form.
        /// </summary>
        /// <param name="student"></param>
        /// <param name="picture"></param>
        public StudentForm(Student student, Image picture)
        {
            if (student.TennisPlayerInfo.TimetableList != null)
            {
                this.studentTimetableList = student.TennisPlayerInfo.TimetableList;
            }
            else
            {
                this.studentLevelCbox.SelectedIndex = 0;
                this.studentTimetableList = new List<StudentTimetable>();
            }

            this.studentID = student.ID;
            InitializeComponent();
            FillInformation(student, picture);
        }

        /// <summary>
        /// Sets the data to the controls of the form.
        /// </summary>
        private void FillInformation(Student student, Image picture)
        {
            inputInformation.SetNameTextBox(student.Name);
            inputInformation.SetSurnameTextBox(student.Surname);
            inputInformation.SetPhoneNumUpDown(student.PhoneNumber);
            inputInformation.SetHomeNumUpDown(student.HomePhoneNumber);
            inputInformation.SetHomeAddressTextBox(student.HomeAddress);
            inputInformation.SetDOBdateTimePicker(student.DateOfBirth);
            inputInformation.SetEmailTextBox(student.Email);
            inputInformation.SetGenderRadioButton(student.Gender);

            fatherPhoneNumUpDown.Value = Convert.ToDecimal(student.FatherPhoneNumber);
            motherPhoneNumUpDown.Value = Convert.ToDecimal(student.MotherPhoneNumber);
            fatherNameTbox.Text = student.FatherName;
            motherNameTbox.Text = student.MotherName;
            staNumUpDown.Value = student.TennisAssociationNum;
            healthCertificateNumUpDown.Value = student.HealthCertificateNum;
            studentLevelCbox.SelectedIndex = (int)student.StudentLevel;

            for (int i = 0; i < studentTimetableList.Count; i++)
            {
                int lessonNum = i + 1;
                lessonsListBox.Items.Add("Lesson " + lessonNum.ToString());
            }

            if (picture != null)
                searchPicture.MainPictureBoxImage = picture;
        }

        /// <summary>
        /// Raises the SaveStudent event safely
        /// </summary>
        /// <param name="student"></param>
        private void RaiseSaveStudentEvent(Student student, Image picture)
        {
            if(SaveStudent != null)
            {
                SaveStudent(student, picture);
            }
        }

        /// <summary>
        /// Checks if the format is correct and displays visually which fields are not entered correctly.
        /// </summary>
        /// <returns></returns>
        private bool IsFormatCorrect()
        {
            bool correct = true;


            if (fatherNameTbox.Text.Any(char.IsDigit))
            {
                fatherNameLabel.ForeColor = Color.Red;
                fatherNameTbox.Text = "";
                correct = false;
            }
            else
            {
                fatherNameLabel.ForeColor = Color.Black;
            }

            if (motherNameTbox.Text.Any(char.IsDigit))
            {
                motherNameLabel.ForeColor = Color.Red;
                motherNameTbox.Text = "";
                correct = false;
            }
            else
            {
                motherNameLabel.ForeColor = Color.Black;
            }

            return correct;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (inputInformation.SetupInformation() && IsFormatCorrect())
            {
                Student student = new Student(studentID, inputInformation.PersonInfo.Name, inputInformation.PersonInfo.Surname,
                    inputInformation.PersonInfo.Gender, inputInformation.PersonInfo.PhoneNumber,
                    inputInformation.PersonInfo.HomePhoneNumber, inputInformation.PersonInfo.HomeAddress, inputInformation.PersonInfo.DateOfBirth,
                    inputInformation.PersonInfo.Email, (Student.StudentSkillLevel)studentLevelCbox.SelectedIndex, studentTimetableList, InputInformation.CorrectInputFormat(fatherNameTbox.Text),
                    InputInformation.CorrectInputFormat(motherNameTbox.Text), fatherPhoneNumUpDown.Value.ToString(), motherPhoneNumUpDown.Value.ToString(), (uint)staNumUpDown.Value, (uint)healthCertificateNumUpDown.Value);


                RaiseSaveStudentEvent(student, searchPicture.MainPictureBoxImage);

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
            TimetableInputForm timetableForm = new TimetableInputForm(PersonType.Student);
            timetableForm.SaveStudentTimetable += timetableForm_SaveNewStudentTimetable;
            timetableForm.ShowDialog();
            if (!timetableForm.IsDisposed)
                timetableForm.Dispose();
        }

        private void timetableForm_SaveNewStudentTimetable(StudentTimetable studentTimetable)
        {
            studentTimetableList.Add(studentTimetable);
            lessonsListBox.Items.Add("Lesson " + studentTimetableList.Count.ToString());
        }

        private void timetableForm_SaveExistingStudentTimetable(StudentTimetable studentTimetable)
        {
            studentTimetableList[lessonsListBox.SelectedIndex] = studentTimetable;
        }

        private void lessonsListBox_MouseUp(object sender, MouseEventArgs e)
        {
            lessonsListBox.SelectedIndex = lessonsListBox.IndexFromPoint(e.X, e.Y);
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (lessonsListBox.Items.Count > 0 && lessonsListBox.SelectedIndex != -1)
                    lessonContextMenuStrip.Show(MousePosition);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableInputForm timetableForm = new TimetableInputForm(studentTimetableList[lessonsListBox.SelectedIndex]);
            timetableForm.SaveStudentTimetable += timetableForm_SaveExistingStudentTimetable;
            timetableForm.ShowDialog();
            if (!timetableForm.IsDisposed)
                timetableForm.Dispose();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentTimetableList.RemoveAt(lessonsListBox.SelectedIndex);
            lessonsListBox.Items.RemoveAt(lessonsListBox.SelectedIndex);
        }
    }
}
