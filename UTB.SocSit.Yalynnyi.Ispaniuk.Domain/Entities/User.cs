using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(User))]
    public class User : Entity
    {
        public required string Email { get; set; }
        public required string Nickname { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public required string Photo { get; set; }
        public required string Password { get; set; }
        public required DateTime Updated { get; set; }
        public required DateTime? Deleted { get; set; }
        public required DateTime? Birthday { get; set; }
    }
}
