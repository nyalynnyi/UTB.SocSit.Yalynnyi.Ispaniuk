using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
using Microsoft.AspNetCore.Identity;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Post")]
    public class PostController : Controller
    {
        ISecurityService _securityService;
        IPostService _postService;

        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Post> posts = _postService.SelectAll();
            return View(posts);
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
