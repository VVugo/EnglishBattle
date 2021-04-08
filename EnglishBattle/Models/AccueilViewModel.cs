using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnglishBattle.Models
{
    public class AccueilViewModel
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "Votre email n'est pas renseigné")]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Votre mot de passe n'est pas renseigné")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}