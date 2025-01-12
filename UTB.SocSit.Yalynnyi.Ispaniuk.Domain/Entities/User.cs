using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Validations;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(User))]
    public class User : Entity
    {
        public required string Email { get; set; }
        [UsernameChars]
        public required string UserName { get; set; }
        [NameChars]
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public required string Photo { get; set; }
        public required string Password { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
