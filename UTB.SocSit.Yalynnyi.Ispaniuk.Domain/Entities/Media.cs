using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Media))]
    public class Media : Entity
    {
        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }

        public required string Link {  get; set; }
        public DateTime? Deleted { get; set; }
    }
}
