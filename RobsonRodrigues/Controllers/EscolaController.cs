using RobsonRodrigues.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobsonRodrigues.Controllers
{
    public class EscolaController : Controller
    {
        // GET: Escola
        public ActionResult Index()
        {
            List<AULA_MD> ListarAulas = new List<AULA_MD>();
            return View(ListarAulas);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}