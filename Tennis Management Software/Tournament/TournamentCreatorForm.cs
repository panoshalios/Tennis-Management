using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Management_Software.Saving;
using Tennis_Management_Software.Timetabling.Visualization;

namespace Tennis_Management_Software.Tournament
{
    public partial class TournamentCreatorForm : Form
    {
        private TournamentSettings tournamentSettings;
        private Cell selectedCell;
        private string textToSet;
        private string filepathToSave;
        private bool changesSaved;
        private List<List<Cell>> CellList2D;

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Tournament.TournamentCreatorForm class.
        /// </summary>
        /// <param name="personNum"></param>
        public TournamentCreatorForm(int personNum)
        {
            InitializeComponent();
            filepathToSave = string.Empty;
            changesSaved = true;
            tournamentSettings = new TournamentSettings();
            int numOfCells = personNum + (personNum - 1);
            tournamentSettings.NumberOfPersons = personNum;

            for (int i = 0; i < numOfCells; i++)
            {
                tournamentSettings.ColorList.Add(Color.Black);
            }

            DrawLayout(personNum);

            //Adds the event handlers
            foreach (Cell cell in CellList2D[0])
            {
                cell.MouseClick += cell_MouseClick;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.Tournament.TournamentCreatorForm class.
        /// </summary>
        public TournamentCreatorForm()
        {
            InitializeComponent();
            filepathToSave = string.Empty;
            changesSaved = false;
            tournamentSettings = new TournamentSettings();
        }

        /// <summary>
        /// Draws the cells and the lines on the panel.
        /// </summary>
        /// <param name="personNum"></param>
        private void DrawLayout(int personNum)
        {
            if (tournamentSettings.ColorList.Count == 0)
            {
                int numOfCells = personNum + (personNum - 1);
                for (int i = 0; i < numOfCells; i++)
                {
                    tournamentSettings.ColorList.Add(Color.Black);
                }
            }

            CellList2D = DrawCells(personNum);
            tournamentSettings.DrawLines = true;
            drawingPanel.Refresh();
        }

        /// <summary>
        /// Draws the cell on the panel and returns the cells.
        /// </summary>
        /// <param name="personNum"></param>
        /// <returns></returns>
        private List<List<Cell>> DrawCells(int personNum)
        {
            const int startingX = 10;
            const int startingY = 40;
            const int diffY = 35;
            const int diffX = 35;

            int depth = (int)Math.Log(personNum, 2);

            int cellsInColumn = personNum;

            List<Cell> cellList = new List<Cell>();
            List<List<Cell>> cellList2D = new List<List<Cell>>();
            int listCounter = -1;
            int cellCounter = 0;

            while (depth >= 0)
            {
                for (int i = 0; i < cellsInColumn; i++)
                {
                    Cell cell = new Cell(Cell.CellAttribute.Normal);
                    if (cellsInColumn == personNum && i == 0)
                    {
                        cell.Location = new Point(startingX, startingY);
                        //cell.MouseClick += cell_MouseClick;
                    }
                    else if (cellsInColumn == personNum)
                    {
                        cell.Location = new Point(startingX, cellList[i - 1].Location.Y + cellList[i - 1].Height + diffY);
                        //cell.MouseClick += cell_MouseClick;
                    }
                    else
                    {
                        cell.Location = new Point(cellList2D[listCounter][0].Location.X + cellList2D[listCounter][0].Width + diffX,
                        (cellList2D[listCounter][cellCounter].Location.Y + cellList2D[listCounter][cellCounter + 1].Location.Y) / 2);
                        cellCounter += 2;
                    }
                    cellList.Add(cell);
                    drawingPanel.Controls.Add(cell);
                }

                cellList2D.Add(cellList.ToList());
                cellList.Clear();
                depth--;
                cellsInColumn -= (int)Math.Pow(2, depth);
                listCounter++;
                cellCounter = 0;
            }
            return cellList2D;
        }

        /// <summary>
        /// Saves the tournament.
        /// </summary>
        /// <param name="filepath"></param>
        private void SaveTournament(string filepath)
        {
            tournamentSettings.cellText.Clear();
            List<string> cellTextList = new List<string>();

            for (int i = 0; i < CellList2D.Count; i++)
            {
                for (int j = 0; j < CellList2D[i].Count; j++)
                {
                    cellTextList.Add(CellList2D[i][j].GetLabelText());
                }
                tournamentSettings.cellText.Add(cellTextList.ToList());
                cellTextList.Clear();
            }

            Serialization.Serialize(tournamentSettings, filepath, false);
        }

        /// <summary>
        /// Loads the tournament.
        /// </summary>
        /// <param name="filepath"></param>
        public void LoadTournament(string filepath)
        {
            if (System.IO.File.Exists(filepath))
            {
                //Setting the title of the form
                this.Text = filepath.Substring(filepath.LastIndexOf('\\') + 1, filepath.Length - filepath.LastIndexOf('.') - 1) + " - Tournament";

                filepathToSave = filepath;
                changesSaved = true;

                tournamentSettings = Serialization.Deserialize<TournamentSettings>(filepath);
                DrawLayout(tournamentSettings.NumberOfPersons);

                if (tournamentSettings.TournamentStarted)
                    startTournamentToolStripMenuItem.Enabled = false;
                else
                {
                    foreach (Cell cell in CellList2D[0])
                        cell.MouseClick += cell_MouseClick;
                }

                int subscriberCounter = 0;

                for (int i = 0; i < CellList2D.Count; i++)
                {
                    for (int j = 0; j < CellList2D[i].Count; j++)
                    {
                        CellList2D[i][j].SetText(tournamentSettings.cellText[i][j]);

                        if (tournamentSettings.TournamentStarted && tournamentSettings.SubscribedToDoubleClick[subscriberCounter])
                            CellList2D[i][j].MouseDoubleClick += cell_MouseDoubleClick;

                        subscriberCounter++;
                    }
                }
            }
        }

        /// <summary>
        /// Returns a value indicating if the parameter is an even number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool IsEven(int num)
        {
            return (num & 1) == 0 ? true : false;
        }

        private void cell_MouseClick(object sender, MouseEventArgs e)
        {
            selectedCell = (Cell)sender;

            SelectPersonForm selectPersonFRM = new SelectPersonForm(MainForm.Tennis_Club.StudentFullNameList);
            selectPersonFRM.GetSelectedPerson += selectPersonFRM_GetSelectedPerson;
            selectPersonFRM.ShowDialog();

            if (!selectPersonFRM.IsDisposed)
                selectPersonFRM.Dispose();
        }

        private void selectPersonFRM_GetSelectedPerson(string personName)
        {
            selectedCell.SetText(personName);
            changesSaved = false;
            drawingPanel.Refresh();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (tournamentSettings.DrawLines)
            {
                int diffX = 10;

                int cellCounter = 0;
                Pen pen = new Pen(Color.Black, 3.0f);
                int colorCounter = 0;

                using(Graphics g = e.Graphics)
                {
                    for (int i = 0; i < CellList2D.Count - 1; i++)
                    {
                        for (int j = 0; j < CellList2D[i].Count; j++)
                        {
                            if (IsEven(j) && j != 0)
                            {
                                cellCounter++;
                            }

                            pen.Color = tournamentSettings.ColorList[colorCounter];

                            Point fromHorizontal = new Point(CellList2D[i][j].Location.X, CellList2D[i][j].MidPointLocation().Y);
                            Point toHorizontal = new Point(CellList2D[i + 1][0].Location.X - diffX, CellList2D[i][j].MidPointLocation().Y);

                            Point fromVertical = toHorizontal;
                            Point toVertical = new Point(fromVertical.X, CellList2D[i + 1][cellCounter].MidPointLocation().Y);

                            //Horizontal
                            g.DrawLine(pen, fromHorizontal, toHorizontal);
                            //Vertical
                            g.DrawLine(pen, fromVertical, toVertical);

                            fromHorizontal.X = toVertical.X;
                            fromHorizontal.Y = toVertical.Y;
                            toHorizontal.X = CellList2D[i + 1][cellCounter].MidPointLocation().X;
                            toHorizontal.Y = fromHorizontal.Y;
                            
                            //Second Horizontal
                            if (colorCounter > 0)
                                if (tournamentSettings.ColorList[colorCounter - 1] == Color.Red)
                                    pen.Color = Color.Red;

                            g.DrawLine(pen, fromHorizontal, toHorizontal);
                            colorCounter++;
                        }
                        cellCounter = 0;
                    }
                }
                pen.Dispose();
            }
        }

        private void startTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Cell cell in CellList2D[0])
            {
                //Tournament cannot start.
                if (cell.GetLabelText() == string.Empty)
                {
                    MessageBox.Show("The tournament cannot start yet since not all participants have been selected.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            tournamentSettings.TournamentStarted = true;
            startTournamentToolStripMenuItem.Enabled = false;
            changesSaved = false;

            for (int i = 0; i < CellList2D.Count - 1; i++)
            {
                for (int j = 0; j < CellList2D[i].Count; j++)
                {
                    if(i == 0)
                    {
                        CellList2D[i][j].MouseClick -= cell_MouseClick;
                    }

                    CellList2D[i][j].MouseDoubleClick += cell_MouseDoubleClick;
                    tournamentSettings.SubscribedToDoubleClick.Add(true);
                }
            }
            //For the final cell
            tournamentSettings.SubscribedToDoubleClick.Add(true);
        }

        private void cell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cell cell = (Cell)sender;
            if(cell.GetLabelText() != string.Empty)
            {
                bool finished = false;
                int cellCounter = 0;
                int colorCounter = 0;

                string personName;

                if (cell.GetLabelText().Contains('\n'))
                    personName = cell.GetLabelText().Substring(0, cell.GetLabelText().IndexOf('\n'));
                else
                    personName = cell.GetLabelText();

                if(MessageBox.Show("Are you sure that you want to confirm that " + personName + " has won the match?",
                    "Tennis Management Software", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    changesSaved = false;

                    for (int i = 0; i < CellList2D.Count - 1; i++)
                    {
                        if (finished)
                            break;

                        for (int j = 0; j < CellList2D[i].Count; j++)
                        {
                            if(j != 0 && IsEven(j))
                            {
                                cellCounter++;
                            }
                            if (cell.Location == CellList2D[i][j].Location)
                            {
                                if ((IsEven(j) && CellList2D[i][j + 1].GetLabelText() != string.Empty) ||
                                    (!IsEven(j) && CellList2D[i][j - 1].GetLabelText() != string.Empty))
                                {
                                    if (cell.GetLabelText().Contains('\n'))
                                        textToSet = cell.GetLabelText().Substring(0, cell.GetLabelText().IndexOf('\n')) + "\nScore: ";
                                    else
                                        textToSet = cell.GetLabelText() + "\nScore: ";
                                    
                                    SetScoreForm scf = new SetScoreForm();
                                    scf.ScoreSet += scf_ScoreSet;
                                    scf.ShowDialog();

                                    if (!scf.IsDisposed)
                                        scf.Dispose();

                                    CellList2D[i + 1][cellCounter].SetText(textToSet);
                                    textToSet = string.Empty;

                                    //Change pen color
                                    tournamentSettings.ColorList[colorCounter] = Color.Red;

                                    CellList2D[i][j].MouseDoubleClick -= cell_MouseDoubleClick;

                                    if (j != 0 && !IsEven(j))
                                    {
                                        CellList2D[i][j - 1].MouseDoubleClick -= cell_MouseDoubleClick;
                                        tournamentSettings.SubscribedToDoubleClick[colorCounter - 1] = false;
                                    }
                                    else
                                    {
                                        CellList2D[i][j + 1].MouseDoubleClick -= cell_MouseDoubleClick;
                                        tournamentSettings.SubscribedToDoubleClick[colorCounter + 1] = false;
                                    }
                                    tournamentSettings.SubscribedToDoubleClick[colorCounter] = false;
                                    finished = true;
                                    break;   
                                }
                                else
                                {
                                    MessageBox.Show("Cannot complete action since adjacent player has not finished his previous match.",
                                        "Tennis Mangement Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                            }
                            colorCounter++;
                        }
                        cellCounter = 0;
                    }
                    drawingPanel.Refresh();
                }
            }
        }

        private void scf_ScoreSet(string score)
        {
            textToSet += score;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                if (filepathToSave != string.Empty)
                {
                    SaveTournament(filepathToSave);
                    changesSaved = true;
                }
                else
                {
                    using (SaveFileDialog fileDialog = new SaveFileDialog())
                    {
                        fileDialog.Title = "Save The Tournament";
                        fileDialog.Filter = "Tournament Files|*.tmst";
                        if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            filepathToSave = fileDialog.FileName;
                            SaveTournament(filepathToSave);
                            changesSaved = true;
                            this.Text = filepathToSave.Substring(filepathToSave.LastIndexOf('\\') + 1, filepathToSave.Length - filepathToSave.LastIndexOf('.') - 1) + " - Tournament";
                        }
                    }
                }
            }
        }

        private void TournamentCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!changesSaved)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit without saving?", "Tennis Management Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        saveToolStripMenuItem.PerformClick();
                        break;
                }
            }
        }
    }
}
