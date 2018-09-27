using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Management_Software
{
    public partial class SettingsForm : Form
    {
        public delegate void SaveSettingsArgs(LessonFees fees);
        public event SaveSettingsArgs SaveSettings;

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.SettingsForm class.
        /// </summary>
        /// <param name="fees">The values to set the NumericUpDowns.</param>
        public SettingsForm(LessonFees fees)
        {
            InitializeComponent();
            privateLessonNumUpDown.Value = (decimal)fees.PrivateFee;
            groupLessonNumUpDown.Value = (decimal)fees.GroupFee;
            semiPrivateNumUpDown.Value = (decimal)fees.SemiPrivateFee;
        }

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.SettingsForm class.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            privateLessonNumUpDown.Value = 0.00M;
            groupLessonNumUpDown.Value = 0.00M;
            semiPrivateNumUpDown.Value = 0.00M;
        }
        
        /// <summary>
        /// Raises the SaveSettingsEvent safely.
        /// </summary>
        /// <param name="settings"></param>
        private void RaiseSaveSettingsEvent(LessonFees settings)
        {
            if (SaveSettings != null)
            {
                SaveSettings(settings);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            const int decimalPlaces = 2;
            LessonFees settings = new LessonFees((float)Math.Round(privateLessonNumUpDown.Value, decimalPlaces), (float)Math.Round(semiPrivateNumUpDown.Value, decimalPlaces),(float)Math.Round(groupLessonNumUpDown.Value, decimalPlaces));
            RaiseSaveSettingsEvent(settings);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
