using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using IdentUser = UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.User;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.ViewModels
{
    public class PostViewModel
    {
        public bool Admin { get; set; }
        public IList<Post> Posts { get; set; }
        public List<IList<Comment>> CommentsList { get; set; }
        public List<IList<Media>> MediaList { get; set; }
        public List<IdentUser> UsersList { get; set; }
        public List<string> Names { get; set; }
        public List<IdentUser> Follows { get; set; }

        public string? Text { get; set; }
        public IFormFile? Image { get; set; }
    }
}
