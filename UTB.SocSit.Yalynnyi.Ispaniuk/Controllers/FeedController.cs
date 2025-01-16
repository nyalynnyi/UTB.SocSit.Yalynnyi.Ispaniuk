using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using IdentUser = UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.User;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.Enums;
using UTB.SocSit.Yalynnyi.Ispaniuk.Models;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.ViewModels;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        private readonly IUserService _userService;
        private readonly ISecurityService _securityService;
        private readonly IPostService _postService;
        private readonly ILogger<ProfileController> _logger;
        private readonly UserManager<IdentUser> _userManager;

        public FeedController(ISecurityService securityService, IUserService userService, IPostService postService, ILogger<ProfileController> logger, UserManager<IdentUser> userManager)
        {
            _securityService = securityService;
            _userService = userService;
            _postService = postService;
            _logger = logger;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                IList<Post> posts = _postService.SelectAll();
                posts = posts.OrderByDescending(p => p.Created).ToList();
                List<IList<Comment>> commentsList = new List<IList<Comment>>();
                List<IList<Media>> mediaList = new List<IList<Media>>();
                List<IdentUser> usersList = new List<IdentUser>();
                List<string> names = new List<string>();
                for (int i = 0; i < posts.Count; i++)
                {
                    IList<Comment> comments = _postService.GetComments(posts[i].ID);
                    IList<Media> media = _postService.GetMedia(posts[i].ID);
                    commentsList.Add(comments);
                    mediaList.Add(media);
                    foreach (var comment in comments)
                    {
                        IdentUser commentUser = _userService.FindById(comment.UserID);
                        usersList.Add(commentUser);
                    }

                    IdentUser author = _userService.FindById(posts[i].UserID);
                    names.Add(author.UserName);
                }
                IdentUser user = _userService.FindByName(User.Identity.Name);
                List<IdentUser> follows = new List<IdentUser> { };
                follows = _userService.FindFriends(user.Id);

                //ViewBag.Posts = posts;
                //ViewBag.CommentsList = commentsList;
                //ViewBag.UsersList = usersList;
                //ViewBag.MediaList = mediaList;
                //ViewBag.Names = names;
                //ViewBag.Follows = follows;

                bool admin;
                if (User.IsInRole(nameof(Roles.Admin)))
                {
                    admin = true;
                    var vm = new PostViewModel
                    {
                        Posts = posts,
                        Admin = admin,
                        CommentsList = commentsList,
                        UsersList = usersList,
                        MediaList = mediaList,
                        Names = names,
                        Follows = follows,
                    };
                    //ViewBag.Admin = admin;
                    //return View(ViewBag);
                    return View(vm);
                }
                else
                {
                    admin = false;
                    var vm = new PostViewModel
                    {
                        Posts = posts,
                        Admin = admin,
                        CommentsList = commentsList,
                        UsersList = usersList,
                        MediaList = mediaList,
                        Names = names,
                        Follows = follows,
                    };
                    //ViewBag.Admin = admin;
                    return View(vm);
                }
            }
            else return Redirect("/");
        }

        [Route("Post/Create")]
        public IActionResult Create(PostViewModel pvm)
        {
            Console.WriteLine("Creating new post...");
            IdentUser user = _userService.FindByName(User.Identity.Name);
            Post newPost = new Post
            {
                Text = pvm.Text,
                UserID = user.Id,
                Created = DateTime.Now
            };
            _postService.Create(newPost);
            return RedirectToAction(nameof(FeedController.Index), nameof(FeedController).Replace(nameof(Controller), string.Empty));
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
