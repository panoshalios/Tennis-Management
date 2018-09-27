using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Tennis_Management_Software.ClientNetwork;

namespace Tennis_Management_Software
{
    public partial class LoginForm : Form
    {
        private Client client;

        public LoginForm()
        {
            InitializeComponent();
            client = new Client();
            client.DataReceived += client_DataReceived;
        }

        void client_DataReceived(object sender, DataReceivedEventArgs e)
        {
            switch (e.Packet.Header.PacketID)
            {
                case Packet.PacketID.LoginSuccessful:
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                    break;
                case Packet.PacketID.LoginFailed:
                    MessageBox.Show(e.Packet.GetData(), "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            client.SendDataAsync(Client.CreateDataForSending(usernameTBOX.Text + "-" + passwordTBOX.Text, Packet.PacketID.Login));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(client.Connect())
            {
                loginBTN.Enabled = true;
            }
            else
            {
                loginBTN.Enabled = false;
                MessageBox.Show("Cannot connect to server.", "Tennis Management Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
