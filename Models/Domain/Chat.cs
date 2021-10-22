using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessangerAPI.Models.Domain
{
    public class Chat
    {
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public ChatType Type { get; set; }

        [NotMapped]
        public List<User> Users { get; set; }

        public Chat()
        {
            Users = new List<User>();
        }
    }
}
