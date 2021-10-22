using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessangerAPI.Models.Domain
{
    public class Attachment
    {
        [Key]
        public Int64 Id { get; set; }
        public String Path { get; set; }
        public String Name { get; set; }
        public DateTime Datetime { get; set; }
        public Int64 OwnerId { get; set; }

        public User Owner { get; set; }
    }
}
