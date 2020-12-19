using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuildManager.Data;
using GuildManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace GuildManager.Controllers
{
    public class CharacterController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private ApplicationDbContext context { get; set; }

        public CharacterController(ApplicationDbContext ctx, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            context = ctx;
        }

        [Authorize]
        public IActionResult MyCharacters()
        {
            // Gets user ID for session, then calls method to get all characters belonging to that ID.
            string userID = _userManager.GetUserId(HttpContext.User);

            Character character = new Character();

            List<Character> characters = character.GetAllCharacters(context, userID);

            return View(characters);
        }
      
        public IActionResult Add()
        {
            // Basic GET to get form.
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Character character)
        {
            // Validates, gets user ID to complete character model, then calls method to save character.
            character.GuildmemberID = _userManager.GetUserId(HttpContext.User);

            if (ModelState.IsValid)
            {
                character.SaveCharacter(context, character);

                return Redirect("/Character/MyCharacters");
            }
            else
            {
                return View(character);
            }
            
        }

        public IActionResult Edit(int characterID)
        {
            // Populates Edit view with character info.
            Character character = new Character();

            character = character.GetCharacterByID(context, characterID);

            return View(character);
        }

        [HttpPost]
        public IActionResult Edit(Character character)
        {
            // Validates, then calls method to update character.
            string userID = _userManager.GetUserId(HttpContext.User);

            if (ModelState.IsValid)
            {
                character.UpdateCharacter(context, character, userID);

                return Redirect("/Character/MyCharacters");
            }
            else
            {
                return View(character);
            }

        }

        public IActionResult Delete(int characterID)
        {
            // Calls methos to retrieve user for verification view.
            Character character = new Character();

            character = character.GetCharacterByID(context, characterID);

            return View(character);
        }

        [HttpPost]
        public IActionResult Delete(Character character, string delete, string cancel)
        {
            // Calls method to delete after delete is confirmed by user.
            if (!string.IsNullOrEmpty(delete))
            {
                character.DeleteCharacter(context, character);
            }
            if (!string.IsNullOrEmpty(cancel))
            {
                
            }
            return Redirect("/Character/MyCharacters");
        }
    }
}