using System.ComponentModel.DataAnnotations;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool LoginFailed { get; set; }
    }
}