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
    public partial class LudoForm : Form
    {

        private AuthenticationHandler authenticationHandler;
        private OnlineUserHandler onlineUserHandler;
        private ChatHandler chatHandler;
        private User user;

        public LudoForm()
        {
            InitializeComponent();
            rootConnectTableLayout.Hide();
            rootServerTableLayout.Hide();
            //this.ludoForm = this;
            //this.onlineUserList = onlineUserList;
        }

        public void updateOnlineUserList()
        {
            printOnlineUsers();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rootConnectTableLayout.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mainConnectTableLayout.Show();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //connectButton.Enabled = false;
            Main main = new Main(); // Run Construtor of Main to initialize Main Ludo Object
            String serverAdress = serverTextBox.Text;
            String userName = userNameTextBox.Text;
            ClientBase.serverAdress = serverAdress;

            user = new User();
            user.UserName = userName;
            //Main.ludo.Users.Add(user);

            authenticationHandler = new AuthenticationHandler(user);

            if (authenticationSuceed())
            {
                onlineUserHandler = new OnlineUserHandler(this.onlineUserList);
                chatHandler = new ChatHandler(this.messageList);

                rootConnectTableLayout.Hide();
                rootServerTableLayout.Show();
                //printOnlineUsers();
            }
            else
            {
                MessageBox.Show("Authentication failed!");
                //connectButton.Enabled = true;
            }
        }

        private bool authenticationSuceed()
        {
            while (!handshaked()); // wait until the authentication succeed
            if (ClientBase.myUserListIndex != -1 && Main.ludo.Users[0].IsUserNameAvailable)
            {
                return true; // when username is avaible and request is through
            }
            else
            {
                //Main.ludo.Users.Remove(this.user);
                //ClientBase.myUserListIndex = -1;
                return false;
            }
        }

        private bool handshaked()
        {
            if (ClientBase.myUserListIndex != -1 && Main.ludo.Users[0].Handshaked)
            {
                return true; // Successfully authenticated
            }
            else
            {
                return false; // Not authenticated yet
            }
        }

        private void printOnlineUsers()
        {
            foreach (var user in Main.ludo.Users)
            {
                onlineUserList.Items.Add(user.UserName);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Button Clicked");
            ludo_client.dto.Message message = new ludo_client.dto.Message();
            foreach (var user in Main.ludo.Users)
            {
                message.Sender = Main.ludo.Users[ClientBase.myUserListIndex];

            }
            message.Msg = messageTextBox.Text;
            Main.ludo.Chat.Add(message);
            this.chatHandler.sendMessage();
        }
    }
}

