using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishBattle.Data.Service
{
    public class VerbeService
    {
        private EnglishBattleEntities context;

        public VerbeService(EnglishBattleEntities context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retourne la liste des verbes
        /// </summary>
        /// <returns>List Verbes</returns>
        public List<Verbe> GetList()
        {
            using (context)
            {

                return context.Verbes.ToList();
            }
        }
    }
}
