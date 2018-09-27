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
    public partial class SelectPersonForm : Form
    {
        public delegate void GetSelectedPersonArgs(string personName);
        public event GetSelectedPersonArgs GetSelectedPerson;

        /// <summary>
        /// Initializes a new instance of the Tennis_Management_Software.SelectPerson class.
        /// </summary>
        /// <param name="nameList"></param>
        public SelectPersonForm(string[] nameList)
        {
            InitializeComponent();

            if (nameList.Count() > 0)
            {
                FillListBox(nameList);
            }
            else
            {
                MessageBox.Show("No persons available.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Fills the list box with the array of names.
        /// </summary>
        /// <param name="nameList">The names to fill the list box.</param>
        private void FillListBox(string[] nameList)
        {
            if(nameList.Count() > 0)
                foreach (string name in nameList)
                    mainListBox.Items.Add(name);
        }

        /// <summary>
        /// Raises the GetSelectedPerson event safely.
        /// </summary>
        /// <param name="personName">The name of the person.</param>
        private void RaiseGetSelectedPersonEvent(string personName)
        {
            if (GetSelectedPerson != null)
            {
                GetSelectedPerson(personName);
            }
        }

        private void mainListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainListBox.SelectedIndex = mainListBox.IndexFromPoint(e.X, e.Y);
            if (mainListBox.SelectedIndex > -1)
            {
                RaiseGetSelectedPersonEvent(mainListBox.GetItemText(mainListBox.Items[mainListBox.SelectedIndex]));
                this.Close();
            }
        }

    }
}
