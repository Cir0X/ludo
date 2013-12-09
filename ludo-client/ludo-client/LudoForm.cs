using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            connectButton.Enabled = false;
            
            Main main = new Main(); // Run Construtor of Main to initialize Main Ludo Object
            String serverAdress = serverTextBox.Text;
            String userName = userNameTextBox.Text;
            ClientBase.serverAdress = serverAdress;

            user = new User();
            user.UserName = userName;
            Main.ludo.Users.Add(user);

            authenticationHandler = new AuthenticationHandler(user);

            if (authenticationSuceed())
            {
                onlineUserHandler = new OnlineUserHandler(this.onlineUserList);
                chatHandler = new ChatHandler(this.messageList);

                rootConnectTableLayout.Hide();
                rootServerTableLayout.Show();
                messageTextBox.Focus();
                this.UseWaitCursor = false;
            }
            else
            {
                ClientBase.myUserListIndex = -1;
                Main.ludo.Users.Clear();
                connectButton.Enabled = true;
            }
        }

        private bool authenticationSuceed()
        {
            while (!handshaked()); // wait for handshake with server
            if (isUserNameAvailable())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool handshaked()
        {
            if (Main.ludo.Users[0].Handshaked)
            {
                return true; // Successfully authenticated
            }
            else
            {
                return false; // Not authenticated yet
            }
        }

        private bool isUserNameAvailable()
        {
            if (Main.ludo.Users[0].IsUserNameAvailable)
            {
                return true; // Username is available
            }
            else
            {
                return false; // Username isn't available
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
            MessageBox.Show("Click!");
            if (!messageTextBox.Text.Equals("") && !messageTextBox.Text.Equals(" "))
            {
                MessageBox.Show("Send message");
                ludo_client.dto.Message message = new ludo_client.dto.Message();
                message.Sender = Main.ludo.Users[ClientBase.myUserListIndex];
                message.Msg = messageTextBox.Text;
                //Main.ludo.Chat.Add(message);
                this.chatHandler.sendMessage(message);
                messageTextBox.Clear();
                messageTextBox.Focus();
            }
        }

        // messageTextBox event listener
        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessageButton.PerformClick();
            }
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            //Room room = new Room();
        }
    }
}

