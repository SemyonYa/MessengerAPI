using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessangerAPI.Models.Domain
{
    public class User
    {
        [Key]
        public Int64 Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Login { get; set; }
        public Int32 Status { get; set; }

        public List<Chat> Chats { get; set; }

        public User()
        {
            Chats = new List<Chat>();
        }
    }
}
