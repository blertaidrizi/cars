using System;

namespace CarGo.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string MessageContent { get; set; }
        public DateTime SentAt { get; set; }

        public User Sender { get; set; }
    }
}
