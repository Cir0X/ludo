using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebSocket4Net;
using ludo_client.dto;
using System.Windows.Forms;

namespace ludo_client
{
    class RoomHandler
    {
        private String PORT_ROUTE = ":5003/room";
        private WebSocket websocket;
        private ListView roomList;
        private ListBox usersInLobbyListBox;

        public RoomHandler(ListView roomList, ListBox usersInLobbyListBox)
        {
            this.roomList = roomList;
            this.usersInLobbyListBox = usersInLobbyListBox;
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleRooms);
            websocket.Open();
        }

        ~RoomHandler()
        {
            this.websocket.Close();
        }

        public void createRoom(Room room)
        {
            room.RoomAction = "createRoom";
            websocket.Send(JsonConvert.SerializeObject(room));
            //LudoForm ludoForm = new LudoForm();
            //ludoForm.drawLobby();
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
            Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID = -1;
            room.RoomAction = "leaveRoom";
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        private void handleRooms(object sender, MessageReceivedEventArgs args)
        {
            Main.ludo = JsonConvert.DeserializeObject<Ludo>(args.Message);
            updateRoomList(this.roomList);
            if (Main.ludo.Users[ClientBase.myUserListIndex].CurrentRoomID > -1)
            {
                updateUsersInLobbyListBox(this.usersInLobbyListBox);
            }
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
                usersInLobbyListBox.Items.Add(Main.ludo.Users[userID].UserName);
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
    }
}
