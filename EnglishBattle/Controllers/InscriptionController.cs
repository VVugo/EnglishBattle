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
    public class InscriptionController : Controller
    {
        // GET: Inscription
        public ActionResult Index()
        {
            return View();
        }


        // POST: Inscription/Create
        [HttpPost]
        public ActionResult Inscription(InscriptionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    JoueurService joueurService = new JoueurService(new EnglishBattleEntities());
                    Joueur joueur = new Joueur();

                    joueur.nom = model.Nom;
                    joueur.prenom = model.Prenom;
                    joueur.email = model.Email;
                    joueur.motDePasse = model.Password;
                    joueur.niveau = model.SelectedNiveau;
                    joueur.idVille = model.SelectedVille;

                    joueurService.Insert(joueur);
                }
                ModelState.AddModelError("Inscription", "Succès votre compte est créé");

                return View("Connexion");
            }
            catch
            {
                ModelState.AddModelError("Erreur", "Echec lors de votre inscription");

                return View(model);
            }
        }
    }
}
