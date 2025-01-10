using Microsoft.AspNetCore.Identity;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities.Interfaces;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity
{
    public class User : IdentityUser<int>, IUser<int>
    {
        public override string? Email { get; set; }
        public virtual string? Nickname { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Bio { get; set; }
        public string? Photo { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public DateTime Created { get; set; }
    }
}
