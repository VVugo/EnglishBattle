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
        [Required(ErrorMessage = "Votre nom n'est pas renseigné")]
        public string Nom { get; set; }

        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Votre prénom n'est pas renseigné")]
        public string Prenom { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Votre email n'est pas renseigné")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Votre mot de passe n'est pas renseigné")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Le mot de passe doit avoir entre 1 et 50 caractères", MinimumLength = 1)]
        public string Password { get; set; }

        [DisplayName("Niveau")]
        [Required(ErrorMessage = "Sélectionner votre niveau")]
        public int SelectedNiveau { get; set; }
        public IEnumerable<SelectListItem> Niveau { get; set; }

        [DisplayName("Ville")]
        [Required(ErrorMessage = "Sélectionner une ville")]
        public int SelectedVille { get; set; }
        public IEnumerable<SelectListItem> Villes { get; set; }
    }
}