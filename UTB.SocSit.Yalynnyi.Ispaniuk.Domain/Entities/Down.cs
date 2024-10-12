using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    public class Down : Entity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }
    }
}
