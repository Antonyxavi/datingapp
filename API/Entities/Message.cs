using System;

namespace API.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public int SenderId { get; set; }

        public string SenderUsername { get; set; }

        public Appuser Sender { get; set; }

        public int RecipientId { get; set; }

        public string RecipientUsername { get; set; }

        public Appuser Recipient { get; set; }

        public string Content { get; set; }

        public DateTime? DateRead { get; set; }

        public DateTime MessageSent { get; set; }=DateTime.Now;

        public bool SenderDeleted { get; set; }

        public bool RecipientDeleted { get; set; }


    }
}