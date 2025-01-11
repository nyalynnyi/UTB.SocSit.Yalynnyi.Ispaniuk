using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.ViewModels;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
using UTB.SocSit.Yalynnyi.Ispaniuk.Controllers;
using System.Security.Policy;
namespace UTB.SocSit.Yalynnyi.Ispaniuk.Areas.Security.Controllers
{
    [Area("Security")]
    public class AccountController : Controller
    {
        IAccountService _accountService;
        public AccountController(IAccountService security)
        {
            _accountService = security;
        }
        public IActionResult Register()
        {
            Console.WriteLine("IActionResult Register()");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            Console.WriteLine("Register()");
            if (ModelState.IsValid)
            {
                string[] errors = await _accountService.Register(registerVM, Roles.User);
                if (errors == null)
                {
                    //login the user after registration
                    LoginViewModel loginVM = new LoginViewModel()
                    {
                        Username = registerVM.Username,
                        Password = registerVM.Password
                    };
                    Console.WriteLine("Login()");
                    bool isLogged = await _accountService.Login(loginVM);
                    if (isLogged)
                        return RedirectToAction(nameof(FeedController.Index), nameof(FeedController).Replace(nameof(Controller), String.Empty), new { area = String.Empty });
                    else
                        return RedirectToAction(nameof(Login));
                }
                else
                {
                    //errors to logger
                    Console.WriteLine("registration error:");
                    Console.WriteLine(string.Join(", ", errors));
                }
            }
            return View(registerVM);
        }
        public IActionResult Login()
        {
            Console.WriteLine("Logging view...");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            Console.WriteLine("Logging...");
            if (ModelState.IsValid)
            {
                bool isLogged = await _accountService.Login(loginVM);
                if (isLogged)
                    return RedirectToAction(nameof(FeedController.Index), nameof(FeedController).Replace(nameof(Controller), String.Empty), new { area = String.Empty });
                loginVM.LoginFailed = true;
            }
            else
            {
                Console.WriteLine("ModelState.IsNotValid");
            }
            return View(loginVM);
        }
        
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _accountService.Logout();
            return RedirectToAction(nameof(Login));
        }
    }
}


