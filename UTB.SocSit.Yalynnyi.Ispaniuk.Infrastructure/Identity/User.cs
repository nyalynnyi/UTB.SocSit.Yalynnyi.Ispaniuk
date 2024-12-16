using Microsoft.AspNetCore.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities.Interfaces;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity
{
    internal class User
    {
        public virtual string? Email { get; set; }
        public virtual string? Nickname { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Bio { get; set; }
        //string? Photo { get; set; }
        //string? Password { get; set; }
        //DateTime? Updated { get; set; }
        //DateTime? Deleted { get; set; }
        public virtual DateTime? Birthday { get; set; }
    }
}
