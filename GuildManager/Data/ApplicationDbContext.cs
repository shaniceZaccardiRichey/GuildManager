using System;
using System.Collections.Generic;
using System.Text;
using GuildManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GuildManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            // Seed data for announcement page.
            builder.Entity<Announcement>().HasData(
                
                new Announcement
                {
                    AnnouncementID = 1,
                    Date = new DateTime(2020, 9, 01),
                    Title = "Welcome to The Guild!",
                    Content = @"Our raid times are Tuesday and Saturday, 7pm - 10pm. All required 
                                consumables will be provided before raid.Repairs are covered by 
                                the guild while you are actively raiding with us. Between raids, 
                                be sure to stay active with other guild memebrs. Officers will be 
                                organizing M + Key events as well as rated Battleground events. 
                                Also, make sure to join the guild Discord and select your roles 
                                based on your interests. We will be using Discord for all 
                                announcements, and these roles will allow you to receive notifations 
                                for relevant mentions.If you need anything, feel free to message an 
                                officer in game or on Discord."
                },

                new Announcement
                {
                    AnnouncementID = 2,
                    Date = new DateTime(2020, 12, 06),
                    Title = "Finals Week",
                    Content = @"As finals week appraoches, I will be taking a step back from guild 
                                activities to focus on my schoolwork. I can still be reached via 
                                Discord, but will not be around as often as usual. Officers will 
                                still be around to help, and I encourage you to reach out to them 
                                while I am away. Good luck on your upcoming raids! - Xephira, GM"
                }

            );
            
        }
        
    }
}
