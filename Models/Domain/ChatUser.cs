using System;

namespace MessangerAPI.Models.Domain
{
    public class ChatUser
    {
        public Int64 ChatId { get; set; }
        public Int64 UserId { get; set; }

        public Chat Chat { get; set; }
        public User User { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsOwner { get; set; }
        public ChatUserStatus Status { get; set; }
    }
}
