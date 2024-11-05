using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Follow_init
    {
        public IList<Follow> GetFollows()
        {
            IList<Follow> follows = new List<Follow>();
            follows.Add(new Follow()
            {
                ID = 1,
                UserID = 1,
                FollowerID = 2,
            });
            follows.Add(new Follow()
            {
                ID = 2,
                UserID = 1,
                FollowerID = 2,
            });
            follows.Add(new Follow()
            {
                ID = 3,
                UserID = 1,
                FollowerID = 3,
            });
            follows.Add(new Follow()
            {
                ID = 4,
                UserID = 1,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                ID = 5,
                UserID = 2,
                FollowerID = 1,
            });
            follows.Add(new Follow()
            {
                ID = 6,
                UserID = 2,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                ID = 7,
                UserID = 2,
                FollowerID = 5,
            });
            follows.Add(new Follow()
            {
                ID = 8,
                UserID = 4,
                FollowerID = 5,
            });
            follows.Add(new Follow()
            {
                ID = 9,
                UserID = 5,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                ID = 10,
                UserID = 3,
                FollowerID = 4,
            });
            return follows;
        }
    }
}
