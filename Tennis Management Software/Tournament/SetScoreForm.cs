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
    public partial class SetScoreForm : Form
    {
        public delegate void ScoreSetArgs(string score);
        public event ScoreSetArgs ScoreSet;

        public SetScoreForm()
        {
            InitializeComponent();
        }

        private void RaiseScoreSetEventSafely(string score)
        {
            if (ScoreSet != null)
                ScoreSet(score);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(scoreTextBox.Text != string.Empty)
            {
                RaiseScoreSetEventSafely(scoreTextBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Score must be completed.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
