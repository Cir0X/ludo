﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;

namespace ludo_server.dto
{
    class Room
    {
        private int roomID;
        private String roomName;
        private List<User> usersInRoom;
        private String roomStatus;
        private String roomAction;

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public List<User> UsersInRoom
        {
            get { return usersInRoom; }
            set { usersInRoom = value; }
        }

        public String RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public String RoomAction
        {
            get { return roomAction; }
            set { roomAction = value; }
        }

        public Room()
        {
            this.usersInRoom = new List<User>();
        }

    }
}
