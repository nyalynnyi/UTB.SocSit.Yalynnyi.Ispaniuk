using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Up))]
    public class Up : Entity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }
    }
}
