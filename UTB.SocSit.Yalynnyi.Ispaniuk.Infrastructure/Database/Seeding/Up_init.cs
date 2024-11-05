using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Up_init
    {
        public IList<Up> GetUps()
        {
            IList<Up> ups = new List<Up>();
            ups.Add(new Up()
            {
                ID = 1,
                PostID = 1,
                UserID = 2,
            });
            ups.Add(new Up()
            {
                ID = 2,
                PostID = 1,
                UserID = 4,
            });
            ups.Add(new Up()
            {
                ID = 3,
                PostID = 2,
                UserID = 1,
            });
            ups.Add(new Up()
            {
                ID= 4,
                PostID = 4,
                UserID = 1,
            });
            ups.Add(new Up()
            {
                ID = 5,
                PostID = 4,
                UserID = 5,
            });
            ups.Add(new Up()
            {
                ID = 6,
                PostID = 4,
                UserID = 2,
            });
            ups.Add(new Up()
            {
                ID = 7,
                PostID = 4,
                UserID = 4,
            });
            ups.Add(new Up()
            {
                ID = 8,
                PostID = 5,
                UserID = 4,
            });
            ups.Add(new Up()
            {
                ID = 9,
                PostID = 5,
                UserID = 1,
            });
            ups.Add(new Up()
            {
                ID = 10,
                PostID = 5,
                UserID = 2,
            });
            return ups;
        }
    }
}
