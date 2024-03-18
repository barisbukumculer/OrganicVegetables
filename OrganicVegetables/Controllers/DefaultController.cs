using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganicVegetables.Models.Entity;

namespace OrganicVegetables.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TarımDbEntities db=new TarımDbEntities();
        public ActionResult Index()
        {
            var values = db.TBLURUNLER.ToList();
            return View(values);
        }
    }
}