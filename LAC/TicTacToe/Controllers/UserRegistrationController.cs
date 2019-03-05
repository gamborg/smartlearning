using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;
using TicTacToe.Services;

namespace TicTacToe.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly IUserService _userService;

        public UserRegistrationController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {

                await _userService.RegisterUser(userModel);
                return RedirectToAction(nameof(EmailConfirmation), new { userModel.Email });
            }

            return View(userModel);
        }

        public IActionResult EmailConfirmation(string email)
        {
            ViewBag.Email = email;
            return View();
        }

    }
}