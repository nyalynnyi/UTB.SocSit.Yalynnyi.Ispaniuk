using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Reaction))]
    public class Reaction : Entity
    {
        [ForeignKey(nameof(User))]
        public required int UserID { get; set; }

        [ForeignKey(nameof(Post))]
        public required int PostID { get; set; }
        public required bool Like { get; set; }
    }
}