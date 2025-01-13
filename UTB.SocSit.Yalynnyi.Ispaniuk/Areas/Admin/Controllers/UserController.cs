using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Implementation;
using UTB.SocSit.Yalynnyi.Ispaniuk.Controllers;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities.Interfaces;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;
        private readonly UserManager<Infrastructure.Identity.User> _userManager;

        public UserController(IUserService userService, ILogger<UserController> logger, UserManager<Infrastructure.Identity.User> userManager)
        {
            _userService = userService;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // Check if the user is authenticated
            if (!User.Identity.IsAuthenticated)
            {
                Console.WriteLine("User is not authenticated. Redirecting to login page.");
                return Redirect("/");
            }

            // Check if the user has the Admin role
            if (User.IsInRole(nameof(Roles.Admin)))
            {
                Console.WriteLine($"Admin user accessed the user management page: {User.Identity.Name}");

                // Fetch all users from the service
                IList<Infrastructure.Identity.User> users = _userService.SelectAll();
                return View(users);
            }

            // Redirect non-admin users to the feed page
            Console.WriteLine($"Access denied for non-admin user: {User.Identity.Name}");
            return RedirectToAction(nameof(FeedController.Index), nameof(FeedController).Replace(nameof(Controller), string.Empty));
        }

        [HttpGet("Delete/{param1}")]
        public async Task<IActionResult> Delete(int param1)
        {
            var user = await _userManager.FindByIdAsync(param1.ToString());
            if (user == null)
            {
                Console.WriteLine("notfound");
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View("Error");
        }

        [HttpGet("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
