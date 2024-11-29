using Microsoft.AspNetCore.Mvc;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.User.Controllers
{
    [Area("User")]
    public class FollowingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
