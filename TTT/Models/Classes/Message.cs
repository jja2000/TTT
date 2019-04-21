using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTT.Models.Classes
{
    public class Message
    {
        public int Id { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public string Content { get; set; }
        public File File { get; set; }
        public string Timestamp { get; set; }

        public Message(int id, User sender, User receiver, string content, string timestamp)
        {
            this.Id = id;
            this.Sender = sender;
            this.Receiver = receiver;
            this.Content = content;
            this.Timestamp = timestamp;
        }

        public Message(int id, User sender, User receiver, File file, string timestamp)
        {
            this.Id = id;
            this.Sender = sender;
            this.Receiver = receiver;
            this.File = file;
            this.Timestamp = timestamp;
        }
    }
}
