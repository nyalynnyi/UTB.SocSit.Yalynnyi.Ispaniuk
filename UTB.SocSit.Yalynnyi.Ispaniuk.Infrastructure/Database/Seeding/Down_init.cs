using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Down_init
    {
        public IList<Down> GetDowns()
        {
            IList<Down> downs = new List<Down>();
            downs.Add(new Down()
            {
                ID = 1,
                PostID = 4,
                UserID = 3,
            });
            return downs;
        }
    }
}
