using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Controllers;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Post")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            // If the user is not authenticated, redirect to login page
            if (!User.Identity.IsAuthenticated)
            {
                _logger.LogInformation("User is not authenticated. Redirecting to login page.");
                return Redirect("/");
            }

            // Check if the user is an admin
            if (User.IsInRole(nameof(Roles.Admin)))
            {
                _logger.LogInformation("Admin user accessed the post index.");
                IList<Post> posts = _postService.SelectAll();
                return View(posts);
            }

            // If the user is authenticated but not an admin, redirect to the feed
            _logger.LogWarning($"Access denied for non-admin user: {User.Identity.Name}");
            return RedirectToAction(nameof(FeedController.Index), nameof(FeedController).Replace(nameof(Controller), string.Empty));
        }

    [HttpPost("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool deleted = _postService.Delete(id);
            return RedirectToAction("Index");
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
