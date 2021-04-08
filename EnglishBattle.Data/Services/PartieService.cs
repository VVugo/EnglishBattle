using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Services
{
    class PartieService
    {
        private EnglishBattleEntities context;

        public PartieService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne la meilleur partie d'un joueur
        /// </summary>
        /// <param id="id">id</param>
        /// <returns>objet partie</returns>
        public Partie GetItem(int id)
        {
            using (context)
            {
                IQueryable<Partie> parties = from partie in context.Parties
                                                       where partie.idJoueur == id
                                                       select partie;

                return parties.FirstOrDefault();
            }
        }

        /// <summary>
        /// Retourne tous les meilleurs scores
        /// </summary>
        /// <returns>objet partie</returns>
        public Partie GetItem()
        {
            using (context)
            {
                IQueryable<Partie> parties = from partie in context.Parties

                                             select partie;

                return parties.ToList();
            }
        }
    }
}
