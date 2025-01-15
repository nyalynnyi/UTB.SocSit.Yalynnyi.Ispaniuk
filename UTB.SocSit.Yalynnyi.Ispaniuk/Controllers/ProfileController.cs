using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using IdentUser = UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.User;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Controllers
{
    [Route("Profile")]

    public class ProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly ISecurityService _securityService;
        private readonly IPostService _postService;
        private readonly ILogger<ProfileController> _logger;
        private readonly UserManager<Infrastructure.Identity.User> _userManager;
        public ProfileController(ISecurityService securityService, IUserService userService,  IPostService postService, ILogger<ProfileController> logger, UserManager<Infrastructure.Identity.User> userManager)
        {
            _securityService = securityService;
            _userService = userService;
            _postService = postService;
            _logger = logger;
            _userManager = userManager;
        }

        [Route("")]
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                Console.WriteLine("User is not authenticated. Redirecting to login page.");
                return Redirect("/");
            }

            IdentUser user = _userService.FindByName(User.Identity.Name);
            if (user == null)
            {
                Console.WriteLine("User is not authenticated. Redirecting to login page. Error:userIdentity");
                return Redirect("/");
            }

            IList<Post> posts = _postService.Select(user.Id);
            posts = posts.OrderByDescending(p => p.Created).ToList();
            List<IList<Comment>> commentsList = new List<IList<Comment>>();
            List<IList<Media>> mediaList = new List<IList<Media>>();
            List<IdentUser> usersList = new List<IdentUser>();
            for (int i = 0; i < posts.Count; i++)
            {
                IList<Comment> comments = _postService.GetComments(posts[i].ID);
                IList<Media> media = _postService.GetMedia(posts[i].ID);
                commentsList.Add(comments);
                mediaList.Add(media);
                foreach (var comment in comments) {
                    IdentUser commentUser = _userService.FindById(comment.UserID);
                    usersList.Add(commentUser);
                }
            }

            var model = new CompositeModel
            {
                User = user,
                Posts = posts,
                CommentList = commentsList,
                MediaList = mediaList,
                UsersList = usersList
            };

            return View(model);
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }

    public class CompositeModel
    {
        public Infrastructure.Identity.User User { get; set; }
        public IList<Post> Posts { get; set; }
        public List<IList<Comment>> CommentList { get; set; }
        public List<IList<Media>> MediaList { get; set; }
        public List<IdentUser> UsersList { get; set; }
    }
}