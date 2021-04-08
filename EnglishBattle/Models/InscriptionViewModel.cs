using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnglishBattle.Models
{
    public class InscriptionViewModel
    {
        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le nom n'est pas renseigné")]
        public string Nom { get; set; }

        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Le prénom n'est pas renseigné")]
        public string Prenom { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "L'email n'est pas renseigné")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Le mot de passe n'est pas renseigné")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Niveau")]
        [Required(ErrorMessage = "Sélectionner votre niveau")]
        public string SelectedNiveau { get; set; }
        public IEnumerable<SelectListItem> Niveau { get; set; }

        [DisplayName("Ville")]
        [Required(ErrorMessage = "Sélectionner une ville")]
        public string SelectedVille { get; set; }
        public IEnumerable<SelectListItem> Ville { get; set; }
    }
}