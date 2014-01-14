using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_client.dto;
using Newtonsoft.Json;
using WebSocket4Net;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ludo_client
{
    class GameHandler
    {
        private String PORT_ROUTE = ":5004/game";
        private TableLayoutPanel gamePanel;
        private TableLayoutPanel gameFieldPanel;
        private PictureBox dicePictureBox;
        private Button rollTheDiceButton;
        private ListBox playerListBox;
        private WebSocket websocket;
        private Room oldRoom;

        public GameHandler(TableLayoutPanel gamePanel, TableLayoutPanel gameFieldPanel, PictureBox dicePictureBox,
            Button rollTheDiceButton, ListBox playerListBox)
        {
            this.gamePanel = gamePanel;
            this.gameFieldPanel = gameFieldPanel;
            this.dicePictureBox = dicePictureBox;
            this.rollTheDiceButton = rollTheDiceButton;
            this.playerListBox = playerListBox;
            this.oldRoom = new Room();

            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleGame);
            websocket.Open();

            showGamePanel();

            //Room room = new Room();
            //room.RoomAction = "iAmInGame";
            //websocket.Send(JsonConvert.SerializeObject(room));
        }

        private void handleGame(object sender, MessageReceivedEventArgs args)
        {
            oldRoom = Main.ludo.Rooms[ClientBase.roomListSelectionID];
            //Room room = JsonConvert.DeserializeObject<Room>(args.Message);
            Main.ludo = JsonConvert.DeserializeObject<Ludo>(args.Message);
            Room room = Main.ludo.Rooms[ClientBase.roomListSelectionID];

            if (room.RoomID == ClientBase.roomListSelectionID) // affects this my room?
            {
                updatePlayerListBox();
                updateRollTheDiceButton(room);
                if (room.RoomAction.Equals("diceRolled"))
                {
                    printDiceValue(room.Game.DiceValue);
                }
                if (room.Game.MoveCount > 0)
                {
                    updateTheMap(room);
                }
            }
        }

        public void rollTheDice()
        {
            Room room = new Room();
            room.RoomAction = "rollTheDice";
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        private bool isItMyTurn(Room room)
        {
            if (room.Game.UsersTurnID == ClientBase.myUserListIndex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // UI Methods
        void fieldPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.Panel)sender).Name + " clicked");
        }

        private void updateTheMap(Room room)
        {
            if (this.gameFieldPanel.InvokeRequired)
            {
                this.gameFieldPanel.Invoke(new MethodInvoker(() => this.updateTheMap(room)));
                return;
            }

            int[,] fields = room.Game.Fields;
            int[,] oldFields = oldRoom.Game.Fields;

           
            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    if (fields[x, y] > -1) {
                        foreach (var userID in room.Game.UserInGameIDs)
                        {
                            //createFieldPanel(x, y, userID);

                            Panel fieldPanel = new Panel();
                            fieldPanel.BackgroundImageLayout = ImageLayout.Stretch;

                            if (userID == fields[x, y])
                            {
                                fieldPanel.BackgroundImage = ludo_client.Properties.Resources.green_circle_3d;
                                this.gameFieldPanel.Controls.Add(fieldPanel, x, y);
                            } 
                            else if (userID == fields[x, y])
                            {
                                fieldPanel.BackgroundImage = ludo_client.Properties.Resources.yellow_circle_3d;
                                this.gameFieldPanel.Controls.Add(fieldPanel, x, y);
                                MessageBox.Show("Added Yellow @: " + x + " " + y);
                            } 
                            else if (userID == fields[x, y])
                            {
                                fieldPanel.BackgroundImage = ludo_client.Properties.Resources.red_circle_3d;
                                this.gameFieldPanel.Controls.Add(fieldPanel, x, y);
                                MessageBox.Show("Added Red @: " + x + " " + y);
                            }
                            else if (userID == fields[x, y])
                            {
                                fieldPanel.BackgroundImage = ludo_client.Properties.Resources.blue_circle_3d;
                                this.gameFieldPanel.Controls.Add(fieldPanel, x, y);
                                MessageBox.Show("Added Blue @: " + x + " " + y);
                            }
                            else
                            {
                                fieldPanel = null;
                            }

                            if (userID == ClientBase.myUserListIndex)
                            {
                                if (fieldPanel != null)
                                {
                                    fieldPanel.Click += new EventHandler(fieldPanel_Click);
                                }
                            }
                        }
                    }
                }
            }

            //Panel panel = (Panel)this.gameFieldPanel.GetControlFromPosition(0, 0);
            //panel.BackgroundImage = ludo_client.Properties.Resources.green_circle_3d;
        }

        private void updateRollTheDiceButton(Room room)
        {
            if (this.rollTheDiceButton.InvokeRequired)
            {
                this.rollTheDiceButton.Invoke(new MethodInvoker(() => this.updateRollTheDiceButton(room)));
            }

            if (isItMyTurn(room))
            {
                this.rollTheDiceButton.Enabled = true;
            }
            else
            {
                this.rollTheDiceButton.Enabled = false;
            }
        }

        private void printDiceValue(byte diceValue)
        {
            if (this.dicePictureBox.InvokeRequired)
            {
                this.dicePictureBox.Invoke(new MethodInvoker(() => this.printDiceValue(diceValue)));
                return;
            }

            if (diceValue == 1)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._1cube;
            }

            if (diceValue == 2)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._2cube;
            }

            if (diceValue == 3)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._3cube;
            }

            if (diceValue == 4)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._4cube;
            }

            if (diceValue == 5)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._5cube;
            }

            if (diceValue == 6)
            {
                this.dicePictureBox.BackgroundImage = ludo_client.Properties.Resources._6cube;
            }
        }

        private void updatePlayerListBox()
        {
            if (this.playerListBox.InvokeRequired)
            {
                this.playerListBox.Invoke(new MethodInvoker(() => this.updatePlayerListBox()));
                return;
            }
            this.playerListBox.Items.Clear();
            foreach (var userID in Main.ludo.Rooms[ClientBase.roomListSelectionID].Game.UserInGameIDs)
            {
                if (userID == Main.ludo.Rooms[ClientBase.roomListSelectionID].Game.UserInGameIDs[0])
                {
                    this.playerListBox.Items.Add("[Green] " + Main.ludo.Users[userID].UserName);
                }
                else if (userID == Main.ludo.Rooms[ClientBase.roomListSelectionID].Game.UserInGameIDs[1])
                {
                    
                    this.playerListBox.Items.Add("[Yellow] " + Main.ludo.Users[userID].UserName);
                }
                else if (userID == Main.ludo.Rooms[ClientBase.roomListSelectionID].Game.UserInGameIDs[2])
                {
                    this.playerListBox.Items.Add("[Red] " + Main.ludo.Users[userID].UserName);
                }
                else if (userID == Main.ludo.Rooms[ClientBase.roomListSelectionID].Game.UserInGameIDs[3])
                {
                    this.playerListBox.Items.Add("[Blue] " + Main.ludo.Users[userID].UserName);
                }
            }
        }

        private void showGamePanel() {
            if (this.gamePanel.InvokeRequired)
            {
                this.gamePanel.Invoke(new MethodInvoker(() => this.showGamePanel()));
                return;
            }
            this.gamePanel.Show();
            this.gamePanel.BringToFront();

            //Enable Roll the Dice Button when im the moderator
            if (Main.ludo.Rooms[ClientBase.roomListSelectionID].RoomModeratorUserID == ClientBase.myUserListIndex)
            {
                this.rollTheDiceButton.Enabled = true;
            }
        }
    }
}
