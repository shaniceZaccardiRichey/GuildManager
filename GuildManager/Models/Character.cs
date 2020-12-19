using GuildManager.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuildManager.Models
{
    public class Character
    {
        private ApplicationDbContext context { get; set; }

        public int CharacterID { get; set; } // Primary Key

        // Name
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(16, ErrorMessage = "Name cannot be longer than 16 characters.")]
        public string? Name { get; set; }

        // Status
        [Required(ErrorMessage = "Please designate as Main or Alt.")]
        public CharacterStatus? Status { get; set; }

        // Class
        [Required(ErrorMessage = "Please select a class.")]
        public ClassName? Class { get; set; }

        // Specialization
        [Required(ErrorMessage = "Please select a specialization.")]
        public Spec? Specialization { get; set; }

        // Role
        [Required(ErrorMessage = "Please select a role.")]
        public Role? Role { get; set; }

        // Item Level
        [Required(ErrorMessage = "Please enter your iLvl.")]
        [Range(1, 300, ErrorMessage = "Please enter a valid iLvl. (Between 1 and 300.)")]
        public int? ItemLevel { get; set; }

        // Guild Member
        public string GuildmemberID { get; set; } // Foreign Key
        public IdentityUser User { get; set; }

        public Character()
        {

        }

        public List<Character> GetAllCharacters(ApplicationDbContext ctx, string userID)
        {
            List<Character> characters = ctx.Characters
                .Where(c => c.GuildmemberID == userID)
                .ToList();

            return characters;
        }

        public Character GetCharacterByID(ApplicationDbContext ctx, int id)
        {
            Character character = ctx.Characters
                .Where(c => c.CharacterID == id)
                .ToList()[0];
            return character;
        }

        public void SaveCharacter(ApplicationDbContext ctx, Character character)
        {
            ctx.Add(character);
            ctx.SaveChanges();
        }

        public void UpdateCharacter(ApplicationDbContext ctx, Character character, string userID)
        {
            character.GuildmemberID = userID;

            ctx.Update(character);
            ctx.SaveChanges();
        }

        public void DeleteCharacter(ApplicationDbContext ctx, Character character)
        {
            ctx.Remove(character);
            ctx.SaveChanges();
        }
    }

    // Enums to restrict input. 
    public enum Role { Tank, Healer, DPS };

    public enum CharacterStatus { Main, Alt };

    public enum ClassName
    {
        DK,
        DH,
        Druid,
        Hunter,
        Mage,
        Monk,
        Paladin,
        Priest,
        Rogue,
        Shaman,
        Warlock,
        Warrior
    };

    public enum Spec
    {
        Affliction, Arcane, Arms, Assassination,
        Balance, Blood, BM, Brewmaster,
        Demonology, Destruction, Discipline,
        Elemental, Enhancement,
        Feral, Fire, Frost, Fury,
        Guardian,
        Havoc, Holy,
        Marksmanship, Mistweaver,
        Outlaw,
        Protection,
        Restoration, Retribution,
        Shadow, Subtlety, Survival,
        Unholy,
        Vengeance,
        Windwalker
    };
}
