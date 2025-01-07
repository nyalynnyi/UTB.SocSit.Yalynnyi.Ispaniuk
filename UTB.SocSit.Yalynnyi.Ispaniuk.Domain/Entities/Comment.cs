using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Comment))]
    public class Comment : Entity
    {
        [ForeignKey(nameof(User))]
        public required int UserID { get; set; }

        [ForeignKey(nameof(Post))]
        public required int PostID { get; set; }
        public required string Text { get; set; }

        private DateTime Created { get; set; }
        private DateTime? Deleted { get; set; }
    }
}
