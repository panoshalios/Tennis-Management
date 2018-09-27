using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Management_Software.Tournament
{
    public partial class TournamentOptionForm : Form
    {
        public TournamentOptionForm()
        {
            InitializeComponent();
        }

        private void newTourButton_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Location = new Point(10, 10);
            listBox.Text = "Select the number of persons participating.";
            this.Text = "Select the number of persons participating.";
            listBox.Items.AddRange(new object[] { 2, 4, 8, 16, 32, 64, 128 });
            listBox.Dock = DockStyle.Fill;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            newTourButton.Visible = false;
            openExistingTourButton.Visible = false;
            this.Controls.Add(listBox);
        }

        void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            TournamentCreatorForm tcf = new TournamentCreatorForm((int)listBox.SelectedItem);
            tcf.Show();
           
            if (!listBox.IsDisposed)
                listBox.Dispose();
            this.Close();
        }

        private void openExistingTourButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Select a tournament";
                fileDialog.Filter = "Tournament Files|*.tmst";
                if(fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TournamentCreatorForm tcf = new TournamentCreatorForm();
                    tcf.LoadTournament(fileDialog.FileName);
                    tcf.Show();
                    this.Close();
                }
            }
        }
    }
}
