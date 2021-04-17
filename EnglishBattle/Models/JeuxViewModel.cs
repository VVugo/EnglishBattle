using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnglishBattle.Models
{
    public class JeuxViewModel
    {
        [DisplayName("Prétérit")]
        [Required(ErrorMessage = "Vous devez renseigner ce champ")]
        public string Preterit { get; set; }

        [DisplayName("Participe passé")]
        [Required(ErrorMessage = "Vous devez renseigner ce champ")]
        public string ParticipePasse { get; set; }

    }
}