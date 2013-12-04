using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ludo_client.dto;

namespace ludo_client
{
    public partial class ludoForm : Form
    {


        private Ludo ludo;
        private AuthenticationHandler authenticationHandler;

        public ludoForm()
        {
            ludo = new Ludo();
            InitializeComponent();
            rootConnectTableLayout.Hide();
            rootServerTableLayout.Hide();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rootConnectTableLayout.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mainConnectTableLayout.Show();
        }

        private void connectTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String serverAdress = serverTextBox.Text;
            String userName = userNameTextBox.Text;
            ludo.ServerAdress = serverAdress;
            User user = new User();
            user.UserName = userName;
            ludo.Users.Add(user);
            authenticationHandler = new AuthenticationHandler(ludo);

            rootConnectTableLayout.Hide();
            rootServerTableLayout.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
