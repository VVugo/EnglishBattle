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
    public class JeuxController : Controller
    {
        // GET: Jeux
        public ActionResult Index()
        {
            VerbeService verbeService = new VerbeService(new EnglishBattleEntities());
            List<Verbe> verbes = verbeService.GetList();



            return View();
        }

        
    }
}
