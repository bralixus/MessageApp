using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageApp.Models
{
    public class LoginViewModel
    {
        [Required, DisplayName("Login")]
        public string Login { get; set; }

        [Required, DisplayName("Hasło"), DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }
}