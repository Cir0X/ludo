using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocket4Net;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverLabel_Click(object sender, EventArgs e)
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
        }
    }
}
