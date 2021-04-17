using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnglishBattle.Models
{
    public class ConnexionViewModel
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "L'email doit être renseigné")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Le mot de passe doit être renseigné")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Le mot de passe ne doit pas dépasser 50 caractères", MinimumLength = 1)]
        public string Password { get; set; }
    }
}