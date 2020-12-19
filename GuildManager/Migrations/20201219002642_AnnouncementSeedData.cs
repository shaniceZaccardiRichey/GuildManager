using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuildManager.Migrations
{
    public partial class AnnouncementSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "AnnouncementID", "Content", "Date", "Title" },
                values: new object[] { 1, @"Our raid times are Tuesday and Saturday, 7pm - 10pm. All required 
                                consumables will be provided before raid.Repairs are covered by 
                                the guild while you are actively raiding with us. Between raids, 
                                be sure to stay active with other guild memebrs. Officers will be 
                                organizing M + Key events as well as rated Battleground events. 
                                Also, make sure to join the guild Discord and select your roles 
                                based on your interests. We will be using Discord for all 
                                announcements, and these roles will allow you to receive notifations 
                                for relevant mentions.If you need anything, feel free to message an 
                                officer in game or on Discord.", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welcome to The Guild!" });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "AnnouncementID", "Content", "Date", "Title" },
                values: new object[] { 2, @"As finals week appraoches, I will be taking a step back from guild 
                                activities to focus on my schoolwork. I can still be reached via 
                                Discord, but will not be around as often as usual. Officers will 
                                still be around to help, and I encourage you to reach out to them 
                                while I am away. Good luck on your upcoming raids! - Xephira, GM", new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finals Week" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "AnnouncementID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "AnnouncementID",
                keyValue: 2);
        }
    }
}
