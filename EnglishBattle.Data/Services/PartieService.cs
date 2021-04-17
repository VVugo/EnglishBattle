using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Service
{
    public class PartieService
    {
        private EnglishBattleEntities context;

        public PartieService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne une liste de joueur avec leur score
        /// </summary>
        /// <returns>List Joueur</returns>
        public List<Partie> GetList()
        {
            using (context)
            {
                IQueryable<Partie> parties = from partie in context.Parties
                                             join joueur in context.Joueurs on partie.idJoueur equals joueur.id
                                             select partie;
                return parties.ToList();
            }
        }

        /// <summary>
        /// Insere une nouvelle partie
        /// </summary>
        public void Insert(Partie partie)
        {
            using (context)
            {
                context.Parties.Add(partie);
                context.SaveChanges();
            }
        }
    }
}
