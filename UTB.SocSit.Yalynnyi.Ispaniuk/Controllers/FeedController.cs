using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                bool admin;

                if (User.IsInRole(nameof(Roles.Admin)))
                {
                    admin = true;
                    ViewBag.admin = admin;
                    return View(admin);
                }
                else
                {
                    admin = false;
                    ViewBag.admin = admin;
                    return View(false);
                }
            }
            else return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
