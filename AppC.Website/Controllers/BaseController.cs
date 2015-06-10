using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppC.Website.Models;

namespace AppC.Website.Controllers
{
    public class BaseController : Controller
    {
        AppliedChaosWebsiteEntities bd { get; set; }
        public BaseController()
        {
            bd = new AppliedChaosWebsiteEntities();
            var r = new Random(DateTime.Now.Millisecond);
            var frase = (bd.FrasesCelebres.OrderBy(x => x.id).Skip(r.Next(0, bd.FrasesCelebres.Count())).Take(1)).ToList()[0];
            ViewBag.Frase = frase.Texto;
            ViewBag.Autor = frase.Autor;
        }
    }
}