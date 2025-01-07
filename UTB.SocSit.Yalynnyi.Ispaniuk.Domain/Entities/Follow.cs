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
        public required int UserID { get; set; }

        [ForeignKey(nameof(User))]
        public required int FollowerID { get; set; }
        private DateTime Created { get; set; }
    }
}