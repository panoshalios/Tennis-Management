using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using Tennis_Management_Software.Imaging;
using Tennis_Management_Software.Saving;

namespace Tennis_Management_Software.Timetabling.Visualization
{
    public partial class TimetableCreatorForm : Form
    {
        /*
         * The drawing algorithm works by doing the follwing steps
         * 
         * 1. From a one dimensional list get a two dimensional list according to the tennis court.
         * 2. Sort the two dimensional list according to the time in which the lesson begins.
         * 3. Get a two dimensional list of cells.
         * 4. Get a one dimensional list of integers which in our case are the tennis court numbers.
         * 5. Get the maximum width and height of a cell in a sublist.
         * 6. Set the maximum width and height to the whole sublist of cells and to the days sublist.
         * 7. Add each cell one next to another to the main panel until a row of 7 is complete.
         * 8. To a new line step 7 is repeated for each cell in the sublist.
         * 9. Add a label to the main panel indicating the court number.
         * 10. Repeat steps 5 to 9 until no more cells are in the two dimensional list.
         */

        private const int OriginalX = 2;
        private const int OriginalY = 42;
        private const int NumberOfDays = 8;
        private const int TimetableSpacing = 60;
        private const int TimetableLabelSpacing = 35;
        private const int DayHeaderSpacing = 2;
        private Font labelFont = new Font(new FontFamily("Segoe UI"), 18.0f);

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Timetabling.Visualization.TimetableCreator class.
        /// </summary>
        /// <param name="studentTimetableList"></param>
        /// <param name="personFullName"></param>
        public TimetableCreatorForm(StudentTimetable[] studentTimetableList, string personFullName)
        {
            InitializeComponent();
            this.Text = personFullName + "'s Timetable";

            if(studentTimetableList.Count() > 0)
                ConfigureAndDisplayTimetable(studentTimetableList);
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Timetabling.Visualization.TimetableCreator class.
        /// </summary>
        public TimetableCreatorForm(CoachTimetable[] coachTimetableList, string personFullName)
        {
            InitializeComponent();
            this.Text = personFullName + "'s Timetable";

            if (coachTimetableList.Count() > 0)
                ConfigureAndDisplayTimetable(coachTimetableList);
        }

        /// <summary>
        /// Returns a list of Cells which indicate the days of the week.
        /// </summary>
        private List<Cell> GetDaysCellList()
        {
            string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            List<Cell> cellList = new List<Cell>();
            cellList.Add(new Cell(Cell.CellAttribute.Empty));
            for(int i = 0; i < 7; i++)
            {
                Cell cell = new Cell(Cell.CellAttribute.Heading);
                cell.SetText(daysOfTheWeek[i]);
                cellList.Add(cell);
            }
            return cellList;
        }

        /// <summary>
        /// Configures and displays the Student timetable to the panel.
        /// </summary>
        private void ConfigureAndDisplayTimetable(StudentTimetable[] studentTimetableList)
        {
            List<List<StudentTimetable>> timetableList = GetListOfTennisCourts(studentTimetableList);

            timetableList = Sort2DList(timetableList);

            List<List<Cell>> cellList2D = GetCellList(timetableList);

            int[] courtNumberList = GetCourtNumList(timetableList);

            DisplayTimetable(cellList2D, courtNumberList);
        }

        /// <summary>
        /// Configures and displays the Coach timetable to the panel.
        /// </summary>
        private void ConfigureAndDisplayTimetable(CoachTimetable[] coachTimetableList)
        {
            List<List<CoachTimetable>> timetableList = GetListOfTennisCourts(coachTimetableList);

            timetableList = Sort2DList(timetableList);

            List<List<Cell>> cellList2D = GetCellList(timetableList);

            int[] courtNumList = GetCourtNumList(timetableList);

            DisplayTimetable(cellList2D, courtNumList);
        }

        /// <summary>
        /// Returns an array of integers indicating the courts at which the Person has a lesson.
        /// </summary>
        private int[] GetCourtNumList<T>(List<List<T>> timetableList) where T : Timetable
        {
            List<int> courtNumberList = new List<int>();

            for (int i = 0; i < timetableList.Count; i++)
            {
                courtNumberList.Add(timetableList[i][0].TennisCourtNum);
            }

            return courtNumberList.ToArray();
        }

        /// <summary>
        /// Returns a two-dimensional list of Cell.
        /// </summary>
        private List<List<Cell>> GetCellList(List<List<StudentTimetable>> timetableList)
        {
            List<List<Cell>> cellList2D = new List<List<Cell>>();
            List<Cell> cellList = new List<Cell>();

            //Loop for all the list.
            for (int y = 0; y < timetableList.Count; y++)
            {
                cellList2D.Add(GetDaysCellList());
                
                //Loop for the sub-lists.
                for (int x = 0; x < timetableList[y].Count; x++)
                {
                    //Loop for each cell in a row.
                    for (int j = 0; j < NumberOfDays; j++)
                    {
                        Cell cell;

                        //For the time cell.
                        if (j == 0)
                        {
                            cell = new Cell(Cell.CellAttribute.Heading);
                            cell.SetText(timetableList[y][x].FromTime.GetTime() + " - " + timetableList[y][x].ToTime.GetTime());
                        }
                        else if (j == (int)timetableList[y][x].Day + 1) //Checks if there is a lesson on the specified day.
                        {
                            cell = new Cell(Cell.CellAttribute.Normal);

                            string textToSet = string.Empty;

                            //Checks the type of lesson
                            switch (timetableList[y][x].TypeOfLesson)
                            {
                                case LessonType.Private:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() 
                                        + "\nTennis coach: " + timetableList[y][x].CoachName;
                                    break;
                                case LessonType.SemiPrivate:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() 
                                        + "\nTennis coach: " + timetableList[y][x].CoachName + "\nStudents:\n";

                                    foreach (string student in timetableList[y][x].StudentsNamesInGroup)
                                        textToSet += "-" + student + "\n";
                                    break;
                                case LessonType.Group:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() 
                                        + "\nTennis coach: " + timetableList[y][x].CoachName + "\nStudents:\n";

                                    foreach (string student in timetableList[y][x].StudentsNamesInGroup)
                                        textToSet += "-" + student + "\n";
                                    break;
                            }

                            cell.SetText(textToSet);
                        }
                        else //There is no lesson on this day.
                        {
                            cell = new Cell(Cell.CellAttribute.Empty);
                        }
                        cellList.Add(cell);
                    }
                }

                cellList2D.Add(cellList.ToList());
                cellList.Clear();

            }
            return cellList2D;
        }

        /// <summary>
        /// Returns a two-dimensional list of Cell.
        /// </summary>
        private List<List<Cell>> GetCellList(List<List<CoachTimetable>> timetableList)
        {
            List<List<Cell>> cellList2D = new List<List<Cell>>();
            List<Cell> cellList = new List<Cell>();

            //Loop all the list
            for (int y = 0; y < timetableList.Count; y++)
            {
                cellList2D.Add(GetDaysCellList());
                //Loop the sublist
                for (int x = 0; x < timetableList[y].Count; x++)
                {
                    //Loop the rows
                    for (int j = 0; j < NumberOfDays; j++)
                    {
                        Cell cell;
                        //For the time
                        if (j == 0)
                        {
                            cell = new Cell(Cell.CellAttribute.Heading);
                            cell.SetText(timetableList[y][x].FromTime.GetTime() + " - " + timetableList[y][x].ToTime.GetTime());
                        }
                        else if (j == (int)timetableList[y][x].Day + 1)
                        {
                            cell = new Cell(Cell.CellAttribute.Normal);

                            string textToSet = string.Empty;

                            //Checks the type of lesson.
                            switch (timetableList[y][x].TypeOfLesson)
                            {
                                case LessonType.Private:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() + "\nStundent: " + timetableList[y][x].StudentsNamesInGroup[0];
                                    break;
                                case LessonType.SemiPrivate:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() + "\nStudents:\n";
                                foreach (string student in timetableList[y][x].StudentsNamesInGroup)
                                    textToSet += "-" + student + "\n";
                                    break;
                                case LessonType.Group:
                                    textToSet = "Type of lesson: " + timetableList[y][x].GetLessonType() + "\nStudents:\n";
                                foreach (string student in timetableList[y][x].StudentsNamesInGroup)
                                    textToSet += "-" + student + "\n";
                                    break;
                                default:
                                    break;
                            }

                            cell.SetText(textToSet);
                        }
                        else
                        {
                            cell = new Cell(Cell.CellAttribute.Empty);
                        }
                        cellList.Add(cell);
                    }
                }
                cellList2D.Add(cellList.ToList());
                cellList.Clear();

            }
            return cellList2D;
        }

        /// <summary>
        /// Displays the timetable to the panel.
        /// </summary>
        private void DisplayTimetable(List<List<Cell>> cellList2D, int[] courtNumberList)
        {
            int startY = OriginalY + TimetableLabelSpacing;
            int labelStartY = OriginalY;
            int cellBottom = startY;
            int cellRight = OriginalX;
            int counter = 1;
            int labelCounter = 0;

            for(int i = 0; i < cellList2D.Count; i++)
            {
                if(counter < cellList2D.Count)
                {
                    Size maxCellSize = GetMaxCellSize(cellList2D[counter]);
                    SetCellSize(cellList2D[counter], maxCellSize);
                    
                    //For the days of the week.
                    SetCellSize(cellList2D[counter - 1], maxCellSize);

                    counter += DayHeaderSpacing;
                }

                //Adds the sublist to the panel.
                AddListToPanel(cellList2D[i], ref startY, ref cellBottom, ref cellRight);

                //Checks for a new Sublist.
                if((i - 1) % DayHeaderSpacing == 0)
                {
                    //Adds the labels to the form.
                    if (labelCounter < courtNumberList.Count())
                    {
                        startY = cellBottom;
                        startY += TimetableSpacing;
                        cellBottom = startY;


                        Label label;
                        //Adds the first label to the form.
                        if (labelCounter == 0)
                        {
                            label = CreateLabel(new Point(mainPanel.Width / 2 - 25, labelStartY), "Court number: " + courtNumberList[labelCounter].ToString(), labelFont);
                            labelCounter++;
                            mainPanel.Controls.Add(label);
                        }

                        //Adds all the other labels to the form.
                        if (courtNumberList.Count() > 1)
                        {
                            label = CreateLabel(new Point(mainPanel.Width / 2 - 25, startY), "Court number: " + courtNumberList[labelCounter].ToString(), labelFont);
                            mainPanel.Controls.Add(label);
                        }
                        
                        startY += TimetableLabelSpacing;
                        cellBottom = startY;
                        labelCounter++;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the maximum size of all the cells in the list.
        /// </summary>
        private Size GetMaxCellSize(List<Cell> cellList)
        {
            int maxWidth = int.MinValue, maxHeight = int.MinValue;
            Size maxCellSize = new Size();
            for(int i = 0; i < cellList.Count; i++)
            {
                if (cellList[i].Width > maxWidth)
                {
                    maxWidth = cellList[i].Width;
                }

                if (cellList[i].Height > maxHeight)
                {
                    maxHeight = cellList[i].Height;
                }
            }
            maxCellSize.Width = maxWidth;
            maxCellSize.Height = maxHeight;

            return maxCellSize;
        }

        /// <summary>
        /// Sets the size to all the Cells in the list.
        /// </summary>
        private void SetCellSize(List<Cell> cellList, Size size)
        {
            foreach (Cell cell in cellList)
            {
                cell.Size = size;
                cell.RepositionLabel();
            }
        }

        /// <summary>
        /// Adds a list of cells to the panel.
        /// </summary>
        private void AddListToPanel(List<Cell> cellList, ref int startY, ref int cellBottom, ref int cellRight)
        {
            for (int i = 0; i < cellList.Count; i++)
            {
                if (i == 0 || (i) % NumberOfDays == 0)
                {
                    startY = cellBottom;
                    cellRight = OriginalX;
                }
                cellList[i].Location = new Point(cellRight, startY);
                cellRight = cellList[i].Right;
                cellBottom = cellList[i].Bottom;
                mainPanel.Controls.Add(cellList[i]);
            }
        }

        /// <summary>
        /// Initializes a new label and returns it.
        /// </summary>
        private Label CreateLabel(Point location, string text, Font font)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = font;
            label.Text = text;
            int x = location.X - label.Width / 2;
            label.Location = new Point(x, location.Y);
            label.BackColor = Color.Transparent;
            return label;
        }

        /// <summary>
        /// Sorts a List of Timetables according to time.
        /// </summary>
        private List<T> SortTimetableList<T>(List<T> list) where T : Timetable
        {
            //Bubble sort.
            T tempTimetable;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].FromTime.GreaterThan(list[i].FromTime))
                    {
                        tempTimetable = list[i];
                        list[i] = list[j];
                        list[j] = tempTimetable;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Algorithm to sort a two-dimensional list according to time.
        /// </summary>
        private List<List<T>> Sort2DList<T>(List<List<T>> timetableList) where T : Timetable
        {
            for(int i = 0; i < timetableList.Count; i++)
            {
                List<T> sortedTimetable = SortTimetableList(timetableList[i]);
                timetableList[i] = sortedTimetable;
            }
            return timetableList;
        }

        /// <summary>
        /// Returns a two-dimensional list of Timetables.
        /// </summary>
        private List<List<T>> GetListOfTennisCourts<T>(T[] timetableList) where T : Timetable
        {
            List<List<T>> listOfTimetables = new List<List<T>>();
            int[] courtNumbers = GetCourtNumbers(timetableList);

            for (int i = 0; i < courtNumbers.Count(); i++)
            {
                var iEnum = from timetable in timetableList
                            where timetable.TennisCourtNum == courtNumbers[i]
                            select timetable;
                List<T> list = iEnum.ToList();
                listOfTimetables.Add(list);
            }
            return listOfTimetables;
        }

        /// <summary>
        /// Returns an array of integers indicating the courts at which the Person has a lesson.
        /// </summary>
        private int[] GetCourtNumbers<T>(T[] timetableList) where T : Timetable
        {
            List<int> courtNumbers = new List<int>();
            for (int i = 0; i < timetableList.Count(); i++)
            {
                if (!courtNumbers.Contains(timetableList[i].TennisCourtNum))
                    courtNumbers.Add(timetableList[i].TennisCourtNum);
            }
            return courtNumbers.ToArray();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += printDocument_PrintPage;
            
            printDocument.DefaultPageSettings.Landscape = true;

            if(printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                printDocument.Print();

            
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap image = ImageHandling.GetBitmapFromPanel(mainPanel);
            Rectangle rect = e.MarginBounds;

            rect = ImageHandling.GetResizedRectBoundsFromBitmap(image, rect);

            e.Graphics.DrawImage(image, rect);
            image.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save timetable";
            saveFileDialog.Filter = "Image file (*.png)|*.png";

            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap image = ImageHandling.GetBitmapFromPanel(mainPanel);
                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                image.Dispose();
            }
        }

    }
}