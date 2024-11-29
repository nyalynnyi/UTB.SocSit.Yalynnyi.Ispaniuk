using Microsoft.AspNetCore.Mvc;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        [HttpGet("{id:int}")] // Accepts an integer as "id"
        public IActionResult Index()
        {
            return View();
        }
    }
}
