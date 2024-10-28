﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Comment_init
    {
        public IList<Comment> GetComments()
        {
            IList<Comment> comments = new List<Comment>();
            comments.Add(new Comment()
            {
                Text = "Hello there",
                UserID = 2,
                PostID = 1,
            });
            comments.Add(new Comment()
            {
                Text = "Cool",
                UserID = 4,
                PostID = 1,
            });
            comments.Add(new Comment()
            {
                Text = "New era of social comunication begins today",
                UserID = 5,
                PostID = 1,
            });
            comments.Add(new Comment()
            {
                Text = "Nice job, keep going",
                UserID = 4,
                PostID = 5,
            });
            comments.Add(new Comment()
            {
                Text = "Cool place",
                UserID = 5,
                PostID = 4,
            });
            return comments;
        }
    }
}