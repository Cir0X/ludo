using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_client.dto;

namespace ludo_client.dto
{
    class Message
    {
        private String message;
        private User sender;
        private DateTime timeStamp;

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
    }
}
