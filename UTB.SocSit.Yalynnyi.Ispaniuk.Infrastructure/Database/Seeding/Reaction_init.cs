using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Reaction_init
    {
        public IList<Reaction> GetReactions()
        {
            IList<Reaction> reactions = new List<Reaction>();

            reactions.Add(new Reaction()
            {
                ID = 1,
                PostID = 1,
                UserID = 2,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 2,
                PostID = 1,
                UserID = 4,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 3,
                PostID = 2,
                UserID = 1,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID= 4,
                PostID = 4,
                UserID = 1,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 5,
                PostID = 4,
                UserID = 5,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 6,
                PostID = 4,
                UserID = 2,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 7,
                PostID = 4,
                UserID = 4,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 8,
                PostID = 5,
                UserID = 4,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 9,
                PostID = 5,
                UserID = 1,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 10,
                PostID = 5,
                UserID = 2,
                Like = true
            });
            reactions.Add(new Reaction()
            {
                ID = 11,
                PostID = 4,
                UserID = 3,
                Like = false
            });

            return reactions;
        }
    }
}
