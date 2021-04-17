using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Service
{
    public class VilleService
    {
        private EnglishBattleEntities context;

        public VilleService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne une liste des villes
        /// </summary>
        /// <returns>List Ville</returns>
        public List<Ville> GetList()
        {
            using (context)
            {

                return context.Villes.ToList();
            }
        }
    }
}
