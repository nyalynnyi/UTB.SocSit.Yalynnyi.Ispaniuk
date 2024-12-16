

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities.Interfaces
{
    public interface IUser<TKey> : IEntity<TKey>
    {
        string? Email { get; set; }
        string? Nickname { get; set; }
        string? Name { get; set; }
        string? Bio { get; set; }
        //string? Photo { get; set; }
        //string? Password { get; set; }
        //DateTime? Updated { get; set; }
        //DateTime? Deleted { get; set; }
        DateTime? Birthday { get; set; }
    }
}
