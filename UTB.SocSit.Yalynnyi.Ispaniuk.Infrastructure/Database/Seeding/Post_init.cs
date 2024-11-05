using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Post_init
    {
        public IList<Post> GetPosts()
        {
            IList<Post> posts = new List<Post>();
            posts.Add(new Post()
            {
                ID = 1,
                UserID = 1,
                Text = "This is the first post on this network. Wow"
            });
            posts.Add(new Post()
            {
                ID = 2,
                UserID = 2,
                Text = "Hello world",
            });
            posts.Add(new Post()
            {
                ID = 3,
                UserID = 4,
                Text = "Let's try something new. What about this?"
            });
            posts.Add(new Post()
            {
                ID = 4,
                UserID = 2,
                Text = "My the latest photos from NA"
            });
            posts.Add(new Post()
            {
                ID = 5,
                UserID = 3,
                Text = "My first video from drone. What's your score?"
            });
            return posts;
        }
    }
}
