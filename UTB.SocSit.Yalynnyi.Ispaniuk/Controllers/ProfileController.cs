using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}