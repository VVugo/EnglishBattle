using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Services
{
    class JoueurService
    {
        private EnglishBattleEntities context;

        public JoueurService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne le joueur
        /// </summary>
        /// <param email="emal">email</param>
        /// <param motDePasse="motDePasse">motDePasse</param>
        /// <returns>objet métier</returns>
        public Joueur GetItem(string email, string motDePasse)
        {
            using (context)
            {
                IQueryable<Joueur> joueurs = from joueur in context.Joueurs
                                                       where joueur.email == email
                                                       && joueur.motDePasse == motDePasse
                                                       select joueur;
                return joueurs.FirstOrDefault();
            }
        }

        /// <summary
        /// Insert un joueur
        /// </summary>
        public void Insert(Joueur joueur)
        {
            using (context)
            {
                context.Joueurs.Add(joueur);
                context.SaveChanges();
            }
        }
    }
}
