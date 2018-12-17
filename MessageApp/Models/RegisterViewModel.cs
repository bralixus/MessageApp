using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageApp.Models
{
    public class RegisterViewModel
    {
        [Required, DisplayName("Nazwa użytkownika")]
        public string Login { get; set; }
        
        [Required, DisplayName("E-mail")]
        public string Email { get; set; }

        [Required, DisplayName("Hasło"), DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required, DisplayName("Powtórz Hasło"), Compare("Password"), DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}