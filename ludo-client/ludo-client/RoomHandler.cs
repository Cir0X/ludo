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

        public RoomHandler(ListView roomList)
        {
            this.roomList = roomList;
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
            room.RoomStatus = "Waiting";
            websocket.Send(JsonConvert.SerializeObject(room));
            //LudoForm ludoForm = new LudoForm();
            //ludoForm.drawLobby();
        }

        public void joinRoom(Room room)
        {
            room.RoomAction = "joinRoom";
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        private void handleRooms(object sender, MessageReceivedEventArgs args)
        {
            Main.ludo = JsonConvert.DeserializeObject<Ludo>(args.Message);
            if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomAction.Equals("createRoom"))
            {
                updateRoomList(this.roomList);
            }

            //if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomAction.Equals("joinRoom"))
            //{
            //    updateUsersInLobbyListBox();
            //}
        }

        private void updateUsersInLobbyListBox(ListBox usersInLobbyListBox) 
        {
            if (usersInLobbyListBox.InvokeRequired)
            {
                usersInLobbyListBox.Invoke(new MethodInvoker(() => updateUsersInLobbyListBox(usersInLobbyListBox)));
            }
            usersInLobbyListBox.Items.Clear();
            foreach (var user in Main.ludo.Rooms[ClientBase.roomListSelectionID].UsersInRoom)
            {
                usersInLobbyListBox.Items.Add(user.UserName);
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
                roomItem.SubItems.Add(room.UsersInRoom.Count.ToString());
                roomItem.SubItems.Add(room.RoomStatus);
                roomList.Items.Add(roomItem);
            }
        }
    }
}
