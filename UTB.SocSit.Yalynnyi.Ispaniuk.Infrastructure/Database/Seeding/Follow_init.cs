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
                UserID = 1,
                FollowerID = 2,
            });
            follows.Add(new Follow()
            {
                UserID = 1,
                FollowerID = 2,
            });
            follows.Add(new Follow()
            {
                UserID = 1,
                FollowerID = 3,
            });
            follows.Add(new Follow()
            {
                UserID = 1,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                UserID = 2,
                FollowerID = 1,
            });
            follows.Add(new Follow()
            {
                UserID = 2,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                UserID = 2,
                FollowerID = 5,
            });
            follows.Add(new Follow()
            {
                UserID = 4,
                FollowerID = 5,
            });
            follows.Add(new Follow()
            {
                UserID = 5,
                FollowerID = 4,
            });
            follows.Add(new Follow()
            {
                UserID = 3,
                FollowerID = 4,
            });
            return follows;
        }
    }
}
