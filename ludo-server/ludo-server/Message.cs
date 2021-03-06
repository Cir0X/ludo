﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;

namespace ludo_server.dto
{
    class Message
    {
        private String message;
        private User sender;
        private DateTime timeStamp;
        private int targetRoomID = -1;

        public String Msg
        {
            get { return message; }
            set { message = value; }
        }

        public User Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public int TargetRoomID
        {
            get { return targetRoomID; }
            set { targetRoomID = value; }
        }

    }
}
