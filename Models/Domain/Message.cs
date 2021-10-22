using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessangerAPI.Models.Domain
{
    public class Message
    {
        [Key]
        public Int64 Id { get; set; }
        public String Body { get; set; }
        public bool IsForwarded { get; set; }
        public Int64 AuthorId { get; set; }
        public Int64 ChatId { get; set; }
        public DateTime Datetime { get; set; }


        public User Author { get; set; }
        public Chat Chat { get; set; }
        public List<Attachment> Attachments { get; set; }

    }
}
