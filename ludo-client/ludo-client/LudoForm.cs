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
        private RoomHandler roomHandler;
        private User user;

        public LudoForm()
        {
            InitializeComponent();
            rootConnectTableLayout.Hide();
            rootServerTableLayout.Hide();
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
                Main.ludo.Users[ClientBase.myUserListIndex].CurrentView = "server";
                onlineUserHandler = new OnlineUserHandler(this.onlineUserList);
                chatHandler = new ChatHandler(this.messageList);
                roomHandler = new RoomHandler(this.roomList);

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
            CreateRoomForm createRoomForm = new CreateRoomForm();
            createRoomForm.ShowDialog();
            if (createRoomForm.DialogResult == DialogResult.OK)
            {
                Room room = new Room();
                room.RoomAction = "createRoom";
                room.RoomName = ClientBase.createRoomName;
                roomHandler.createRoom(room);
            }
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (!messageTextBox.Text.Equals("") && !messageTextBox.Text.Equals(" "))
            {
                ludo_client.dto.Message message = new ludo_client.dto.Message();
                message.Sender = Main.ludo.Users[ClientBase.myUserListIndex];
                message.Msg = messageTextBox.Text;
                //Main.ludo.Chat.Add(message);
                this.chatHandler.sendMessage(message);
                messageTextBox.Clear();
                messageTextBox.Focus();
            }
        }

        public void drawLobby()
        {
            this.serverTableLayout.Controls.Remove(this.roomList);
            this.roomList.Visible = false;
            ListBox lobbyListBox = new ListBox();
            this.serverTableLayout.Controls.Add(lobbyListBox);
            lobbyListBox.Visible = true;
        }

        // Form Resize Event Listeneer
        private void ludoForm_ResizeEnd(Object sender, EventArgs e)
        {
            this.roomList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.roomList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void joinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Joining Room Number: " + ClientBase.roomListSelectionID);
            joinRoom();
        }

        private void setRoomListSelectionID()
        {
            ClientBase.roomListSelectionID = this.roomList.FocusedItem.Index;
        }

        private void roomList_Click(object sender, EventArgs e)
        {
            this.joinButton.Enabled = true;
            setRoomListSelectionID();
        }

        private void roomList_DoubleClick(object sender, EventArgs e)
        {
            setRoomListSelectionID();
            joinButton.PerformClick();
        }

        private void joinRoom()
        {
            Main.ludo.Users[ClientBase.myUserListIndex].CurrentView = "lobby";
            // Add this User to userInRoomList
            Main.ludo.Rooms[ClientBase.roomListSelectionID].UsersInRoom.Add(Main.ludo.Users[ClientBase.myUserListIndex]);
            roomHandler.joinRoom(Main.ludo.Rooms[ClientBase.roomListSelectionID]);
            showLobby();
        }

        private void showLobby() 
        {
            this.roomList.Visible = false;
            this.createRoomButton.Visible = false;
            this.joinButton.Visible = false;
            this.backButton.Visible = true;
            this.userInLobbyListBox.Visible = true;
        }

        private void showRoomList()
        {
            this.roomList.Visible = true;
            this.createRoomButton.Visible = true;
            this.joinButton.Visible = true;
            this.backButton.Visible = false;
            this.userInLobbyListBox.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            showRoomList();
        }

    }
}

