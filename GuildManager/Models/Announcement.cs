using GuildManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuildManager.Models
{
    public class Announcement
    {
        /*
         * This class is left basic as I will be populating the data in the OnBuilder for now.
         * In future development, this would be reworked to allow Admin users to input new announcements,
         * and validation of that input would be added during the rework.
         * 
         * This was used at it's basic form to give a demonstration of Entity functionality and seeding 
         * data via OnBuilder, as the Character features use session info for CRUD which I believe will have
         * to be done when you are reviewing the project. 
        */

        private static ApplicationDbContext context { get; set; }

        public int AnnouncementID { get; set; } // Primary Key
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public Announcement() 
        { 

        }

        public static List<Announcement> GetAnnouncements(ApplicationDbContext ctx)
        {
            List<Announcement> announcements = new List<Announcement>();

            announcements = ctx.Announcements.ToList();
       
            return announcements;
        }
    }
}
