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
            string userID = _userManager.GetUserId(HttpContext.User);

            Character character = new Character();

            List<Character> characters = character.GetAllCharacters(context, userID);

            return View(characters);
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(Character character)
        {
            // Get user id
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
            Character character = new Character();

            character = character.GetCharacterByID(context, characterID);

            return View(character);
        }

        [HttpPost]
        public IActionResult Edit(Character character)
        {
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
            Character character = new Character();

            character = character.GetCharacterByID(context, characterID);

            return View(character);
        }

        [HttpPost]
        public IActionResult Delete(Character character, string delete, string cancel)
        {
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