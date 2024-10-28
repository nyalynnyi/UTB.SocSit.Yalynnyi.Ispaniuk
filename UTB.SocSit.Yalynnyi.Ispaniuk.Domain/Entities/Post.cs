using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Post))]
    public class Post : Entity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public required string Text { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
