using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnglishBattle.Data;
namespace EnglishBattle.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Inscription()
        {
            if (ModelState.IsValid)
            {
                JoueurService utilisateurService = new UtilisateurService(TestEF.Data.TestEFEntities());
                Utilisateur utilisateur = new Utilisateur();

                utilisateur.Nom = model.Nom;
                utilisateur.Prenom = model.Prenom;
                utilisateur.Email = model.Email;
                utilisateur.Password = model.Password;

            }
            return View();
        }
    }
}