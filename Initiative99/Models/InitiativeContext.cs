using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Initiative99.Models
{
    public class InitiativeContext : DbContext
    {
        public InitiativeContext(DbContextOptions<InitiativeContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Initiative> Initiatives { get; set; }
        public DbSet<InitiativeAction> InitiativeActions { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingNote> MeetingNote { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<UserInitiativeAction> UserInitiativeActions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<UserInitiativeAction>().HasKey(i => new { i.UserId, i.InitiativeActionId });
		}
    }
}
