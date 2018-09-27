using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tennis_Management_Software.Timetabling
{
    public partial class TimetableInputForm : Form
    {
        private PersonType personType;
        private LessonType lessonType;

        public delegate void SaveStudentTimetableArgs(StudentTimetable studentTimetable);
        public event SaveStudentTimetableArgs SaveStudentTimetable;

        public delegate void SaveCoachTimetableArgs(CoachTimetable coachTimetable);
        public event SaveCoachTimetableArgs SaveCoachTimetable;


        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.TimetableInputForm class.
        /// </summary>
        public TimetableInputForm(PersonType personType)
        {
            InitializeComponent();
            InitializeRadioButtons();
            dayCbox.SelectedIndex = 0;
            this.personType = personType;
            this.lessonType = LessonType.Group;
            if(personType == PersonType.Coach)
            {
                coachPanel.Hide();
                studentsInLessonLabel.Text = "Students in group lesson: ";
            }
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.TimetableInputForm class.
        /// </summary>
        public TimetableInputForm(StudentTimetable studentTimetable)
        {
            InitializeComponent();
            InitializeRadioButtons();
            this.personType = PersonType.Student;
            this.lessonType = studentTimetable.TypeOfLesson;
            FillStudentInformation(studentTimetable);

            switch (lessonType)
            {
                case LessonType.Private:
                    addButton.Enabled = false;
                    studentBrowseButton.Enabled = false;
                    break;
                case LessonType.SemiPrivate:
                    if(studentListBox.Items.Count == 1)
                    {
                        addButton.Enabled = false;
                        studentBrowseButton.Enabled = false;
                    }
                    else
                    {
                        addButton.Enabled = true;
                        studentBrowseButton.Enabled = true;
                    }
                    break;
                case LessonType.Group:
                    addButton.Enabled = true;
                    studentBrowseButton.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.TimetableInputForm class.
        /// </summary>
        public TimetableInputForm(CoachTimetable coachTimetable)
        {
            InitializeComponent();
            InitializeRadioButtons();
            this.personType = PersonType.Coach;
            this.lessonType = coachTimetable.TypeOfLesson;
            coachPanel.Hide();
            studentsInLessonLabel.Text = "Students in group lesson: ";
            FillInformation(coachTimetable);

            switch (lessonType)
            {
                case LessonType.Private:
                    if(studentListBox.Items.Count == 1)
                    {
                        addButton.Enabled = false;
                        studentBrowseButton.Enabled = false;
                    }
                    else
                    {
                        addButton.Enabled = true;
                        studentBrowseButton.Enabled = true;
                    }
                    break;
                case LessonType.SemiPrivate:
                    if(studentListBox.Items.Count == 2)
                    {
                        addButton.Enabled = false;
                        studentBrowseButton.Enabled = false;
                    }
                    else
                    {
                        addButton.Enabled = true;
                        studentBrowseButton.Enabled = true;
                    }
                    break;
                case LessonType.Group:
                    addButton.Enabled = true;
                    studentBrowseButton.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Initialize the radio buttons.
        /// </summary>
        private void InitializeRadioButtons()
        {
            groupLessonRButton.CheckedChanged += radioButtons_CheckedChanged;
            privateLessonRButton.CheckedChanged += radioButtons_CheckedChanged;
            semiPrivateLessonRButton.CheckedChanged += radioButtons_CheckedChanged;
        }

        /// <summary>
        /// Fills the information of the form.
        /// Specifically designed for the Student.
        /// </summary>
        /// <param name="studentTimetable"></param>
        private void FillStudentInformation(StudentTimetable studentTimetable)
        {
            FillInformation(studentTimetable);
            coachNameSurnameTbox.Text = studentTimetable.CoachName;
        }

        /// <summary>
        /// Fills the information of the form.
        /// Desgined for both Student and Coach.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="timetable"></param>
        private void FillInformation<T>(T timetable) where T : Timetable
        {
            dayCbox.SelectedIndex = (int)timetable.Day;
            DateTime fromTime = new DateTime(2000, 1, 1, timetable.FromTime.Hours, timetable.FromTime.Minutes, 0);
            DateTime toTime = new DateTime(2000, 1, 1, timetable.ToTime.Hours, timetable.ToTime.Minutes, 0);
            fromTimePicker.Value = fromTime;
            toTimePicker.Value = toTime;
            tennisCourtNumUpDown.Value = timetable.TennisCourtNum;


            switch (timetable.TypeOfLesson)
            {
                case LessonType.Private:
                    privateLessonRButton.Checked = true;
                    break;
                case LessonType.SemiPrivate:
                    semiPrivateLessonRButton.Checked = true;
                    break;
                case LessonType.Group:
                    groupLessonRButton.Checked = true;
                    break;
                default:
                    groupLessonRButton.Checked = true;
                    break;
            }

            if(timetable.StudentsNamesInGroup != null)
                foreach (string name in timetable.StudentsNamesInGroup)
                    studentListBox.Items.Add(name);
        }

        /// <summary>
        /// Raises the SaveStudentTimetable event safely.
        /// </summary>
        /// <param name="studentTimetable"></param>
        private void RaiseSaveStudentTimetableEvent(StudentTimetable studentTimetable)
        {
            if(SaveStudentTimetable != null)
            {
                SaveStudentTimetable(studentTimetable);
            }
        }

        /// <summary>
        /// Raises the SaveCoachTimetable event safely.
        /// </summary>
        /// <param name="coachTimetable"></param>
        private void RaiseSaveCoachTimetableEvent(CoachTimetable coachTimetable)
        {
           if(SaveCoachTimetable != null)
           {
               SaveCoachTimetable(coachTimetable);
           }
        }

        /// <summary>
        /// Checks if the fields of the form are completed correctly. If fields are not completed correctly visual indication will be shown.
        /// </summary>
        /// <returns></returns>
        private bool AreFieldsComplete()
        {
            bool complete = true;

            //Checks if the value of the from time is greater than the value of the to time
            if (fromTimePicker.Value >= toTimePicker.Value)
            {
                fromTimeLabel.ForeColor = Color.Red;
                toTimeLabel.ForeColor = Color.Red;
                complete = false;
            }
            else
            {
                fromTimeLabel.ForeColor = Color.Black;
                toTimeLabel.ForeColor = Color.Black;
            }


            switch (personType)
            {
                case PersonType.Student:
                    if ((lessonType == LessonType.Group || lessonType == LessonType.SemiPrivate) && studentListBox.Items.Count == 0)
                    {
                        studentsInLessonLabel.ForeColor = Color.Red;
                        complete = false;
                    }
                    else
                    {
                        studentsInLessonLabel.ForeColor = Color.Black;
                    }
                    break;
                case PersonType.Coach:
                    if (studentListBox.Items.Count == 0)
                    {
                        studentsInLessonLabel.ForeColor = Color.Red;
                        complete = false;
                    }
                    else
                    {
                        
                        switch (lessonType)
                        {
                            case LessonType.Private:
                                if (studentListBox.Items.Count < 1)
                                {
                                    studentsInLessonLabel.ForeColor = Color.Red;
                                    complete = false;
                                }
                                else
                                {
                                    studentsInLessonLabel.ForeColor = Color.Black;
                                }
                                break;
                            case LessonType.SemiPrivate:
                                if (studentListBox.Items.Count < 2)
                                {
                                    studentsInLessonLabel.ForeColor = Color.Red;
                                    complete = false;
                                }
                                else
                                {
                                    studentsInLessonLabel.ForeColor = Color.Black;
                                }
                                break;
                        }
                    }
                    break;
            }

            //Checks if the coach text box has been completed correctly
            if (personType == PersonType.Student && (coachNameSurnameTbox.Text.StartsWith(" ") || coachNameSurnameTbox.Text == string.Empty || coachNameSurnameTbox.Text.Any(char.IsDigit)))
            {
                coachNameSurnameLabel.ForeColor = Color.Red;
                complete = false;
            }
            else
            {
                coachNameSurnameLabel.ForeColor = Color.Black;
            }

            return complete;
        }

        /// <summary>
        /// Changes the StudentPanel settings.
        /// </summary>
        private void ChangeStudentPanelSetting()
        {
            switch (personType)
            {
                case PersonType.Student:
                    if (lessonType == LessonType.SemiPrivate && studentListBox.Items.Count == 1)
                    {
                        addButton.Enabled = false;
                        studentBrowseButton.Enabled = false;
                    }
                    break;
                case PersonType.Coach:
                    switch (lessonType)
                    {
                        case LessonType.Private:
                            if (studentListBox.Items.Count == 1)
                            {
                                addButton.Enabled = false;
                                studentBrowseButton.Enabled = false;
                            }
                            break;
                        case LessonType.SemiPrivate:
                            if (studentListBox.Items.Count == 2)
                            {
                                addButton.Enabled = false;
                                studentBrowseButton.Enabled = false;
                            }
                            break;
                    }
                    break;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            addButton.Enabled = true;
            studentBrowseButton.Enabled = true;

            if (groupLessonRButton.Checked)
                lessonType = LessonType.Group;
            else if (privateLessonRButton.Checked)
            {
                lessonType = LessonType.Private;

                if (personType == PersonType.Student)
                {
                    addButton.Enabled = false;
                    studentBrowseButton.Enabled = false;
                }
            }
            else if (semiPrivateLessonRButton.Checked)
            {
                lessonType = LessonType.SemiPrivate;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameSurnameTbox.Text != string.Empty && !nameSurnameTbox.Text.StartsWith(" ") && !nameSurnameTbox.Text.Any(char.IsDigit))
            {
                studentListBox.Items.Add(InputInformation.CorrectInputFormat(nameSurnameTbox.Text));
                nameSurnameTbox.Text = string.Empty;
            }
            else
            {
                nameSurnameTbox.Text = string.Empty;
            }

            ChangeStudentPanelSetting();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm selectPerson = new SelectPersonForm(MainForm.Tennis_Club.StudentFullNameList);
            selectPerson.GetSelectedPerson += selectPerson_GetSelectedStudent;

            if(!selectPerson.IsDisposed)
                selectPerson.ShowDialog();
                
            selectPerson.Dispose();
        }

        private void selectPerson_GetSelectedStudent(string personName)
        {
            studentListBox.Items.Add(personName);
            ChangeStudentPanelSetting();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (AreFieldsComplete())
            {
                Time fromTime = new Time(fromTimePicker.Value.Hour, fromTimePicker.Value.Minute);
                Time toTime = new Time(toTimePicker.Value.Hour, toTimePicker.Value.Minute);

                List<string> studentNameList = new List<string>();
                for (int i = 0; i < studentListBox.Items.Count; i++)
                    studentNameList.Add(studentListBox.GetItemText(studentListBox.Items[i]));


                switch (personType)
                {
                    case PersonType.Student:
                        StudentTimetable studentTimetable;
                        switch (lessonType)
                        {
                            case LessonType.Private:
                                studentTimetable = new StudentTimetable((DayOfWeek)dayCbox.SelectedIndex, fromTime, toTime, (byte)tennisCourtNumUpDown.Value, InputInformation.CorrectInputFormat(coachNameSurnameTbox.Text), lessonType);
                                RaiseSaveStudentTimetableEvent(studentTimetable);
                                break;
                            case LessonType.Group:
                                studentTimetable = new StudentTimetable((DayOfWeek)dayCbox.SelectedIndex, fromTime, toTime, (byte)tennisCourtNumUpDown.Value, studentNameList, InputInformation.CorrectInputFormat(coachNameSurnameTbox.Text), lessonType);
                                RaiseSaveStudentTimetableEvent(studentTimetable);
                                break;
                            case LessonType.SemiPrivate:
                                studentTimetable = new StudentTimetable((DayOfWeek)dayCbox.SelectedIndex, fromTime, toTime, (byte)tennisCourtNumUpDown.Value, studentNameList, InputInformation.CorrectInputFormat(coachNameSurnameTbox.Text), lessonType);
                                RaiseSaveStudentTimetableEvent(studentTimetable);
                                break;
                        }
                        break;
                    case PersonType.Coach:
                        CoachTimetable coachTimetable = new CoachTimetable((DayOfWeek)dayCbox.SelectedIndex, fromTime, toTime, (byte)tennisCourtNumUpDown.Value, studentNameList, lessonType);
                        RaiseSaveCoachTimetableEvent(coachTimetable);
                        break;
                }

                this.Close();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(studentListBox.SelectedIndex != -1)
                studentListBox.Items.RemoveAt(studentListBox.SelectedIndex);

            if(addButton.Enabled == false && studentListBox.Items.Count == 0)
            {
                addButton.Enabled = true;
                studentBrowseButton.Enabled = true;
            }
        }

        private void studentListBox_MouseUp(object sender, MouseEventArgs e)
        {
            studentListBox.SelectedIndex = studentListBox.IndexFromPoint(e.X, e.Y);
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if(studentListBox.Items.Count > 0 && studentListBox.SelectedIndex != -1)
                    removeCMenuStrip.Show(MousePosition);
            }
        }

        private void coachBrowseButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm selectPerson = new SelectPersonForm(MainForm.Tennis_Club.CoachFullNameList);
            selectPerson.GetSelectedPerson += selectPerson_GetSelectedCoach;

            if (!selectPerson.IsDisposed)
                selectPerson.ShowDialog();

            if (!selectPerson.IsDisposed)
                selectPerson.Dispose();
        }

        private void selectPerson_GetSelectedCoach(string personName)
        {
            coachNameSurnameTbox.Text = personName;
        }
    }
}
