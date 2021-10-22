using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MessangerAPI.Models.Domain;

namespace MessangerAPI.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }


        public DbSet<Test> Tests { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatUser>()
                .HasKey(cu => new { cu.ChatId, cu.UserId });

            //modelBuilder.Entity<Chat>()
            //    .
        }
    }
}
