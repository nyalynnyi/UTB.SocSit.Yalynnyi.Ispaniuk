using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Validations;


namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities
{
    [Table(nameof(Media))]
    public class Media : Entity
    {
        [ForeignKey(nameof(Post))]
        public required int PostID { get; set; }
        [NotMapped]
        public required string Link {  get; set; }
        private DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }

        [NotMapped]
        [FileContent("image")]
        public IFormFile? Image { get; set; }
    }
}
