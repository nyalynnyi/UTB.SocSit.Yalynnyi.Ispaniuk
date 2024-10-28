using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Follow))]
    public class Follow : Entity
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        [ForeignKey(nameof(User))]
        public int FollowerID { get; set; }
    }
}