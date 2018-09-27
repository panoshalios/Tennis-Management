using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Printing;
using Tennis_Management_Software.Imaging;
using Tennis_Management_Software.Saving;
using Tennis_Management_Software.Timetabling.Visualization;
using Tennis_Management_Software.Tournament;

namespace Tennis_Management_Software
{
    public partial class MainForm : Form
    {
        private PersonInfo personInfo;
        private const string noImage = "NoImage";
        private const string euroSign = "\u20AC";

        public static TennisClub Tennis_Club;

        /// <summary>
        /// Initialises a new instance of the Tennis_Management_Software.MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            personPictureBox.BackgroundImage = Properties.Resources.NoImage;

            Tennis_Club = new TennisClub();
            Tennis_Club.Load();

            studentCoachCBOX.SelectedIndex = 0;

            FillDataGridView(Tennis_Club.StudentList, true);
            UpdateStatInfoLabelText();
            personInfo.ID = PersonInfo.NullValue;
        }

        

        /// <summary>
        /// Fiils the mainDataGridView with the specified list.
        /// </summary>
        /// <typeparam name="T">An object which inherits the Person class.</typeparam>
        /// <param name="list">Array of T objects.</param>
        /// <param name="sortAlphabetically">Indicates if the mainDataGridView is to be sorted alphabetically.</param>
        private void FillDataGridView<T>(T[] list, bool sortAlphabetically) where T : Person
        {
            mainDataGridView.Rows.Clear();
            foreach (T obj in list)
            {
                string[] row = new string[] { obj.ID.ToString(), obj.Name, obj.Surname, obj.Age.ToString(), obj.GetGender() };
                mainDataGridView.Rows.Add(row);
            }
            if (sortAlphabetically)
                SortDataGridView();
        }

        /// <summary>
        /// Sorts the DataGridView according with the name column in ascending order.
        /// </summary>
        private void SortDataGridView()
        {
            this.mainDataGridView.Sort(this.mainDataGridView.Columns[1], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Returns the index of requested person located in the DataGridView.
        /// </summary>
        /// <param name="type">The type of person to look for.</param>
        /// <param name="id">The id of the person which is to be found.</param>
        /// <returns>Index of the person.</returns>
        private int GetIndexFromID(PersonType type, int id)
        {
            int index = 0;
            if (type == PersonType.Student)
            {
                for (int i = 0; i < Tennis_Club.StudentList.Count(); i++)
                {
                    if (Tennis_Club.StudentList[i].ID == id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            else if (type == PersonType.Coach)
            {
                for (int i = 0; i < Tennis_Club.CoachList.Count(); i++)
                {
                    if (Tennis_Club.CoachList[i].ID == id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// Updates the text of the statistical information label.
        /// </summary>
        private void UpdateStatInfoLabelText()
        {
            statInfoLabel.Text = "Number of students: " + Tennis_Club.StudentList.Count().ToString("#,##0");
            statInfoLabel.Text += "\nNumber of tennis coaches: " + Tennis_Club.CoachList.Count().ToString("#,##0");
            statInfoLabel.Text += "\nNumber of private lessons each week: " + Tennis_Club.GetNumberOfPrivateLessons();
            statInfoLabel.Text += "\nNumber of semi-private lessons each week: " + Tennis_Club.GetNumberOfSemiPrivateLessons();
            statInfoLabel.Text += "\nNumber of group lessons each week: " + Tennis_Club.GetNumberOfGroupLessons();
            statInfoLabel.Text += "\nTotal money gained from private lessons: " + euroSign + Tennis_Club.GetMoneyGainedFromPrivateLessons();
            statInfoLabel.Text += "\nTotal money gained from semi-private lessons: " + euroSign + Tennis_Club.GetMoneyGainedFromSemiPrivateLessons();
            statInfoLabel.Text += "\nTotal money gained from group lessons: " + euroSign + Tennis_Club.GetMoneyGainedFromGroupLessons();
            statInfoLabel.Text += "\nTotal money gained from lessons: " + euroSign + Tennis_Club.GetMoneyGainedFromLessons();
            statInfoLabel.Text += "\nTotal money lost for tennis coaches this month: " + euroSign + Tennis_Club.GetMoneyLostForCoaches();
            statInfoLabel.Text += "\nTotal profit made this month: " + euroSign + Tennis_Club.GetTotalProfit();
        }

        /// <summary>
        /// Displays the information of a Student.
        /// </summary>
        /// <param name="index">The index of the Student.</param>
        private void DisplayStudentInfo(int index)
        {
            if (index >= 0 && index < Tennis_Club.StudentList.Count())
            {
                Student student = Tennis_Club.StudentList[index];

                Image picture = Tennis_Club.GetStudentImage(index);

                if (picture != null)
                    personPictureBox.BackgroundImage = picture;
                else
                    personPictureBox.BackgroundImage = Properties.Resources.NoImage;

                informationLabel.Text = student.GetAllInformation(Tennis_Club.Lesson_Fees.PrivateFee, Tennis_Club.Lesson_Fees.GroupFee, Tennis_Club.Lesson_Fees.SemiPrivateFee);
                GC.Collect();
            }
        }

        /// <summary>
        /// Displays the information of a Coach.
        /// </summary>
        /// <param name="index">The index of the Coach.</param>
        private void DisplayCoachInfo(int index)
        {
            if (index >= 0 && index < Tennis_Club.CoachList.Count())
            {
                Image picture = Tennis_Club.GetCoachImage(index);
                if (picture != null)
                    personPictureBox.BackgroundImage = picture;
                else
                    personPictureBox.BackgroundImage = Properties.Resources.NoImage;

                informationLabel.Text = Tennis_Club.CoachList[index].GetAllInformation();
                GC.Collect();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to exit?", "Tennis Management Software", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                e.Cancel = true;
            Tennis_Club.Save();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Licence, "Tennis Management Software");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            studentCoachCMenuStrip.Show(MousePosition);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            SettingsForm settingsForm = new SettingsForm(Tennis_Club.Lesson_Fees);
            settingsForm.SaveSettings += settingsForm_SaveSettings;
            settingsForm.ShowDialog();
            settingsForm.Dispose();
        }

        private void settingsForm_SaveSettings(LessonFees fees)
        {
            Tennis_Club.Lesson_Fees = fees;
            DisplayStudentInfo(personInfo.ID);
            UpdateStatInfoLabelText();
        }

        private void studentCoachCBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            personInfo.ID = PersonInfo.NullValue;
            informationLabel.Text = "";
            personPictureBox.BackgroundImage = Properties.Resources.NoImage;
            
            switch(studentCoachCBOX.SelectedIndex)
            {
                case (int)PersonType.Student:
                    FillDataGridView(Tennis_Club.StudentList, true);
                    break;

                case (int)PersonType.Coach:
                    FillDataGridView(Tennis_Club.CoachList, true);
                    break;
            }
        }

        private void searchTBOX_TextChanged(object sender, EventArgs e)
        {
            //Fill the data grid view if empty search and return.
            if (searchTBOX.Text == string.Empty)
            {
                switch(studentCoachCBOX.SelectedIndex)
                {
                    case (int)PersonType.Student:
                        FillDataGridView(Tennis_Club.StudentList, true);
                        break;
                    case (int)PersonType.Coach:
                        FillDataGridView(Tennis_Club.CoachList, true);
                        break;
                }
                return;
            }

            //if the search does not start with a space continue.
            if (!searchTBOX.Text.StartsWith(" "))
            {
                //if the search contains a space the we search for both Name and Surname.
                if (searchTBOX.Text.Contains(' '))
                {
                    string name = searchTBOX.Text.Substring(0, searchTBOX.Text.IndexOf(' ')).ToLower();
                    string surname = searchTBOX.Text.Substring(searchTBOX.Text.IndexOf(' ') + 1).ToLower();

                    switch (studentCoachCBOX.SelectedIndex)
                    {
                        case (int)PersonType.Student:
                            FillDataGridView(Tennis_Club.SearchStudents(name, surname), true);
                            break;
                        
                        case (int)PersonType.Coach:
                            FillDataGridView(Tennis_Club.SearchCoaches(name, surname), true);
                            break;
                    }
                }
                //If no space is found the we search only for the name.
                else
                {
                    switch (studentCoachCBOX.SelectedIndex)
                    {
                        case (int)PersonType.Student:
                            Student[] studentSearchResults = Tennis_Club.SearchStudents(searchTBOX.Text.ToLower());
                            FillDataGridView(studentSearchResults, true);
                            break;

                        case (int)PersonType.Coach:
                            Coach[] coachSearchResults = Tennis_Club.SearchCoaches(searchTBOX.Text.ToLower());
                            FillDataGridView(coachSearchResults, true);
                            break;
                    }
                }
            }
        }

        private void mainDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.mainDataGridView.Rows[e.RowIndex];
                personInfo.ID = Convert.ToInt32(row.Cells[0].Value.ToString());

                switch (studentCoachCBOX.SelectedIndex)
                {
                    case (int)PersonType.Student:
                        personInfo.TypeOfPerson = PersonType.Student;
                        DisplayStudentInfo(personInfo.ID);
                        break;
                    case (int)PersonType.Coach:
                        personInfo.TypeOfPerson = PersonType.Coach;
                        DisplayCoachInfo(personInfo.ID);
                        break;
                }
            }
        }

        /// <summary>
        /// Resizes the mainDataGridView.
        /// </summary>
        private void mainDataGridView_SizeChanged(object sender, EventArgs e)
        {
            int diffWidth = 0;
            int numOfVisibleColumns = 0;
            foreach (DataGridViewColumn column in mainDataGridView.Columns)
            {
                //Checks if column is not resizable and not visible
                if (column.Resizable == DataGridViewTriState.False)
                    diffWidth += column.Width;
                //Checks if column is resizable and visible
                else if (column.Resizable == DataGridViewTriState.True && column.Visible)
                    numOfVisibleColumns++;
            }

            //Finds the total resizable width
            int totalResizableWidth = this.mainDataGridView.Width - diffWidth;
            //Finds the width of each column
            int widthOfEachColumn = totalResizableWidth / numOfVisibleColumns;
            foreach (DataGridViewColumn column in mainDataGridView.Columns)
            {
                //Resizes column if visible and resizable
                if (column.Resizable == DataGridViewTriState.True && column.Visible)
                    column.Width = widthOfEachColumn;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (personInfo.ID >= 0)
            {
                if (MessageBox.Show("Are you sure that you want to delete this person?", "Tennis Management Software", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (personInfo.TypeOfPerson)
                    {
                        case PersonType.Student:
                            personPictureBox.BackgroundImage = Properties.Resources.NoImage;
                            Tennis_Club.RemoveStudent(personInfo.ID);
                            FillDataGridView(Tennis_Club.StudentList, true);
                            break;

                        case PersonType.Coach:
                            personPictureBox.BackgroundImage = Properties.Resources.NoImage;
                            Tennis_Club.RemoveCoach(personInfo.ID);
                            FillDataGridView(Tennis_Club.CoachList, true);
                            break;
                    }
                    informationLabel.Text = string.Empty;
                    personInfo.ID = PersonInfo.NullValue;
                    UpdateStatInfoLabelText();
                }
            }
            else
            {
                MessageBox.Show("No person selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm((uint)Tennis_Club.StudentList.Count());
            studentForm.SaveStudent += studentForm_SaveNewStudent;
            studentForm.ShowDialog();
            if (!studentForm.IsDisposed)
                studentForm.Dispose();
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachForm coachForm = new CoachForm((uint)Tennis_Club.CoachList.Count());
            coachForm.SaveCoach += coachForm_SaveNewCoach;
            coachForm.ShowDialog();
            if (!coachForm.IsDisposed)
                coachForm.Dispose();
        }

        private void studentForm_SaveNewStudent(Student student, Image picture)
        {
            Tennis_Club.AddStudent(student, picture);
            UpdateStatInfoLabelText();

            if (studentCoachCBOX.SelectedIndex == (int)PersonType.Student)
                FillDataGridView(Tennis_Club.StudentList, true);
        }

        private void studentForm_SaveExistingStudent(Student student, Image picture)
        {
            Tennis_Club.ReplaceStudent((int)student.ID, student, picture);
            DisplayStudentInfo((int)student.ID);
            UpdateStatInfoLabelText();
            FillDataGridView(Tennis_Club.StudentList, true);
        }

        private void coachForm_SaveNewCoach(Coach coach, Image picture)
        {
            Tennis_Club.AddCoach(coach, picture);
            UpdateStatInfoLabelText();

            if(studentCoachCBOX.SelectedIndex == (int)PersonType.Coach)
                FillDataGridView(Tennis_Club.CoachList, true);
        }

        private void coachForm_SaveExistingCoach(Coach coach, Image picture)
        {
            Tennis_Club.ReplaceCoach((int)coach.ID, coach, picture);
            DisplayCoachInfo((int)coach.ID);
            UpdateStatInfoLabelText();
            FillDataGridView(Tennis_Club.CoachList, true);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (personInfo.ID >= 0)
            {
                if (personInfo.TypeOfPerson == PersonType.Student)
                {
                    StudentForm studentForm = new StudentForm(Tennis_Club.StudentList[personInfo.ID], Tennis_Club.GetStudentImage(personInfo.ID));
                    studentForm.SaveStudent += studentForm_SaveExistingStudent;
                    studentForm.ShowDialog();
                    if (!studentForm.IsDisposed)
                        studentForm.Dispose();
                }
                else
                {
                    CoachForm coachForm = new CoachForm(Tennis_Club.CoachList[personInfo.ID], Tennis_Club.GetCoachImage(personInfo.ID));
                    coachForm.SaveCoach += coachForm_SaveExistingCoach;
                    coachForm.ShowDialog();
                    if (!coachForm.IsDisposed)
                        coachForm.Dispose();
                }
            }
            else
            {
                MessageBox.Show("No person selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void personTimetableButton_Click(object sender, EventArgs e)
        {
            if (personInfo.ID >= 0)
            {
                if (personInfo.TypeOfPerson == PersonType.Student)
                {
                    TimetableCreatorForm timetableCreator = new TimetableCreatorForm(Tennis_Club.StudentList[personInfo.ID].TennisPlayerInfo.TimetableList.ToArray(), Tennis_Club.StudentList[personInfo.ID].FullName);
                    timetableCreator.ShowDialog();
                    timetableCreator.Dispose();
                }
                else
                {
                    TimetableCreatorForm timetableCreator = new TimetableCreatorForm(Tennis_Club.CoachList[personInfo.ID].TennisPlayerInfo.TimetableList.ToArray(), Tennis_Club.CoachList[personInfo.ID].FullName);
                    timetableCreator.ShowDialog();
                    timetableCreator.Dispose();
                }
            }
            else
            {
                MessageBox.Show("No person selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (personInfo.ID >= 0)
            {
                Bitmap informationBitmap = ImageHandling.GetBitmapFromPanel(InformationPanel);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save Image";
                saveDialog.Filter = "Image file (.PNG)|*.png";


                if (personPictureBox.BackgroundImage != Properties.Resources.NoImage)
                {
                    Bitmap pictureBitmap = (Bitmap)personPictureBox.BackgroundImage;
                    ComposeImage ci = new ComposeImage(new Size(pictureBitmap.Width + informationBitmap.Width, pictureBitmap.Height + informationBitmap.Height));
                    ci.Images.Add(new ImagePart(new Point(0, 0), pictureBitmap));
                    ci.Images.Add(new ImagePart(new Point(0, pictureBitmap.Height), informationBitmap));

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ImageHandling.SaveImage(ci.ComposeTheImage(), saveDialog.FileName, ImageFormat.Png);
                        pictureBitmap.Dispose();
                    }

                }
                else if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageHandling.SaveImage(informationBitmap, saveDialog.FileName, ImageFormat.Png);
                }

                informationBitmap.Dispose();
                saveDialog.Dispose();
            }
            else
            {
                MessageBox.Show("No person selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (personInfo.ID >= 0)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument;
                printDocument.PrintPage += printDocument_PrintPage;

                printDocument.DefaultPageSettings.Landscape = true;

                if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    printDocument.Print();
            }
            else
            {
                MessageBox.Show("No person selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap informationBitmap = ImageHandling.GetBitmapFromPanel(InformationPanel);
            Rectangle rect = e.MarginBounds;

            if (personPictureBox.BackgroundImage != Properties.Resources.NoImage)
            {
                Bitmap pictureBitmap = (Bitmap)personPictureBox.BackgroundImage;
                ComposeImage ci = new ComposeImage(new Size(pictureBitmap.Width + informationBitmap.Width, pictureBitmap.Height + informationBitmap.Height));
                ci.Images.Add(new ImagePart(new Point(0, 0), pictureBitmap));
                ci.Images.Add(new ImagePart(new Point(0, pictureBitmap.Height), informationBitmap));

                rect = ImageHandling.GetResizedRectBoundsFromBitmap(ci.ComposeTheImage(), rect);

                e.Graphics.DrawImage(ci.ComposeTheImage(), rect);
            }
            else
            {
                rect = ImageHandling.GetResizedRectBoundsFromBitmap(informationBitmap, rect);
                e.Graphics.DrawImage(informationBitmap, rect);
            }

            informationBitmap.Dispose();
        }

        private void tournamentButton_Click(object sender, EventArgs e)
        {
            TournamentOptionForm tof = new TournamentOptionForm();
            tof.ShowDialog();

            if (!tof.IsDisposed)
                tof.Dispose();
        }
    }
}
