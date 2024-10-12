using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    public class User : Entity
    {
        public required string Email { get; set; }
        public required string Nickname { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public required string Photo { get; set; }
        public string? Pronouns { get; set; }
        public string? Gender { get; set; }
        public required string Password { get; set; }
        public required DateTime Updated { get; set; }
        public required DateTime? Deleted { get; set; }
    }
}
