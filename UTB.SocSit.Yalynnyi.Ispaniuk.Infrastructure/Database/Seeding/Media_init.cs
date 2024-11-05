using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding
{
    internal class Media_init
    {
        public IList<Media> GetMedia()
        {
            IList<Media> media = new List<Media>();
            media.Add(new Media()
            {
                ID = 1,
                PostID = 4,
                Link = "/media/4_1.jpg"
            });
            media.Add(new Media()
            {
                ID = 2,
                PostID = 4,
                Link = "/media/4_2.jpg"
            });
            media.Add(new Media()
            {
                ID = 3,
                PostID = 4,
                Link = "/media/4_3.jpg"
            });
            media.Add(new Media()
            {
                ID = 4,
                PostID = 5,
                Link = "/media/5_1.mp4"
            });

            return media;
        }
    }
}
