using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnglishBattle.Models;
using EnglishBattle.Data;
using EnglishBattle.Data.Service;

namespace EnglishBattle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connexion(ConnexionViewModel model)
        {
            if (ModelState.IsValid)
            {
                JoueurService joueurService = new JoueurService(new Data.EnglishBattleEntities());

                Joueur joueur = joueurService.GetJoueur(model.Email, model.Password);

                if (joueur != null)
                {
                    return View("Jeux");
                }
            }
            ModelState.AddModelError("Connexion", "Echec lors de la tentative de connexion");
            return View(model);
        }

    }
}