using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebSocket4Net;
using ludo_client.dto;
using System.Windows.Forms;
using ludo_client.extensions;

namespace ludo_client
{
    class RoomHandler
    {
        private String PORT_ROUTE = ":5003/room";
        private WebSocket websocket;
        private ListView roomList;
        private ListBox usersInLobbyListBox;
        private Button readyButton;
        private Button startButton;
        Button backButton;
        private RichTextBox roomRichTextBox;

        public RoomHandler(ListView roomList, ListBox usersInLobbyListBox, Button readyButton, Button startButton, Button backButton, RichTextBox roomRichTextBox)
        {
            this.roomList = roomList;
            this.usersInLobbyListBox = usersInLobbyListBox;
            this.readyButton = readyButton;
            this.startButton = startButton;
            this.backButton = backButton;
            this.roomRichTextBox = roomRichTextBox;
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleRooms);
            websocket.Open();
        }

        ~RoomHandler()
        {
            this.websocket.Close();
        }

        // returns the room id which this user has created
        public bool createRoom(Room room)
        {
            room.RoomModeratorUserID = ClientBase.myUserListIndex;
            room.RoomAction = "createRoom";
            websocket.Send(JsonConvert.SerializeObject(room));
            while (!isRoomCreated()); // wait until the room is succesfully created
            return true;
        }

        private bool isRoomCreated()
        {
            foreach (var r in Main.ludo.Rooms)
            {
                if (r.RoomModeratorUserID == ClientBase.myUserListIndex)
                {
                    ClientBase.roomListSelectionID = r.RoomID;
                    return true;
                }
            }
            return false;
        }

        public void joinRoom(Room room)
        {
            //Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID = ClientBase.roomListSelectionID;
            room.RoomAction = "joinRoom";
            room.UserInRoomIDs.Add(ClientBase.myUserListIndex); // Add this user to Room list
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        public void leaveRoom(Room room)
        {
            room.UserInRoomIDs.Remove(ClientBase.myUserListIndex);
            if (Main.ludo.Users[ClientBase.myUserListIndex].StatusInRoom) 
            { 
                // When the User was ready remove him from readyUsersInRoomIDs List
                room.ReadyUsersInRoomIDs.Remove(ClientBase.myUserListIndex); 
            }
            Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID = -1; // set current room id back to default
            room.RoomAction = "leaveRoom";
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        public void setReady(Room room)
        {
            room.RoomAction = "setReady";
            if (Main.ludo.Users[ClientBase.myUserListIndex].StatusInRoom)
            {
                // when he was ready before remove him from readyUsersInRoomIDs List
                room.ReadyUsersInRoomIDs.Remove(ClientBase.myUserListIndex);
                updateButton(this.backButton, true, true);
            }
            else
            {
                // when he was NOT ready before add him to readyUsersInRoomIDs List
                room.ReadyUsersInRoomIDs.Add(ClientBase.myUserListIndex);
                updateButton(this.backButton, true, false);
            }
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        public void setStart(Room room)
        {
            room.RoomAction = "setStart";
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        // MessageReceived Eventhandler
        private void handleRooms(object sender, MessageReceivedEventArgs args)
        {
            Main.ludo = JsonConvert.DeserializeObject<Ludo>(args.Message);
            updateRoomList(this.roomList);
            // when im in a room and the update affects my room
            if (Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID > -1 && 
                Main.ludo.Rooms[Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID].UserInRoomIDs.Contains(ClientBase.myUserListIndex))
            {
                updateUsersInLobbyListBox(this.usersInLobbyListBox);

                if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomModeratorUserID == ClientBase.myUserListIndex)
                {
                    // Enable Start button when this user is moderator
                    updateButton(this.readyButton, false, true);
                    updateButton(this.startButton, true, true);
                }
                else
                {
                    updateButton(this.readyButton, true, true);
                }

                // when the game is starting
                if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomAction.Contains("Starting in"))
                {
                    updateRoomMessageList(this.roomRichTextBox, Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomAction);

                    if (Main.ludo.Users[ClientBase.roomListSelectionID].StatusInRoom)
                    {
                        // deactivate back and ready button when the user was already ready when the game starts
                        updateButton(this.readyButton, true, false);
                        updateButton(this.backButton, true, false);
                    }
                }
            }
        }

        // UI Methods

        private void updateRoomMessageList(RichTextBox richTextBox, String message)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(new MethodInvoker(() => updateRoomMessageList(richTextBox, message)));
                return;
            }
            richTextBox.AppendText("Game is " + message + "\n", System.Drawing.Color.Red);
            richTextBox.ScrollToCaret();
        }

        private void updateUsersInLobbyListBox(ListBox usersInLobbyListBox) 
        {
            if (usersInLobbyListBox.InvokeRequired)
            {
                usersInLobbyListBox.Invoke(new MethodInvoker(() => updateUsersInLobbyListBox(usersInLobbyListBox)));
                return;
            }

            usersInLobbyListBox.Items.Clear();
            foreach (var userID in Main.ludo.Rooms[ClientBase.roomListSelectionID].UserInRoomIDs)
            {
                if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomModeratorUserID == userID)
                {
                    usersInLobbyListBox.Items.Add(Main.ludo.Users[userID].UserName + " [Moderator]");

                    if (Main.ludo.Rooms[ClientBase.roomListSelectionID].ReadyUsersInRoomIDs.Count > 0 &&
                        Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomStatus != "Starting")
                    {
                        updateStartButton(this.startButton, true);
                    }
                    else
                    {
                        updateStartButton(this.startButton, false);
                    }
                }
                else
                {
                    if (Main.ludo.Rooms[ClientBase.roomListSelectionID].ReadyUsersInRoomIDs.Contains(userID))
                    {
                        // When he is ready add ready string
                        if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomStatus == "Starting")
                        {
                            usersInLobbyListBox.Items.Add(Main.ludo.Users[userID].UserName + " [Starting]");
                        }
                        else
                        {
                            usersInLobbyListBox.Items.Add(Main.ludo.Users[userID].UserName + " [Ready]");
                        }
                    }
                    else
                    {
                        usersInLobbyListBox.Items.Add(Main.ludo.Users[userID].UserName);
                    }
                }
            }
        }

        private void updateRoomList(ListView roomList)
        {
            if (roomList.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                roomList.Invoke(new MethodInvoker(() => updateRoomList(roomList)));
                return;
            }

            roomList.Items.Clear();
            foreach (var room in Main.ludo.Rooms)
            {
                ListViewItem roomItem = new ListViewItem();
                roomItem.SubItems[0].Text = room.RoomID.ToString();
                roomItem.SubItems.Add(room.RoomName);
                roomItem.SubItems.Add(room.UserInRoomIDs.Count.ToString() + "/4");
                roomItem.SubItems.Add(room.RoomStatus);
                roomList.Items.Add(roomItem);
            }
        }

        private void updateButton(Button button, bool isVisible, bool enable) 
        {
            if (button.InvokeRequired)
            {
                button.Invoke(new MethodInvoker(() => updateButton(button, isVisible, enable)));
                return;
            }
            button.Visible = isVisible;
        }

        private void updateStartButton(Button button, bool isRoomStartAble)
        {
            if (button.InvokeRequired)
            {
                button.Invoke(new MethodInvoker(() => updateStartButton(button, isRoomStartAble)));
                return;
            }
            if (isRoomStartAble)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}