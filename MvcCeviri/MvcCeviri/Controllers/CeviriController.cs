using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MvcCeviri.Models.Entity;

namespace MvcCeviri.Controllers


{
    public class CeviriController : Controller
    {
        // GET: Ceviri
        TranslateEntities db = new TranslateEntities();
        public ActionResult Index(int? id)
        {
            if(id == null) {
                var c = db.Ceviri.Find(1);
                return View(c);
            } else {
                var c = db.Ceviri.Find(id);
                return View(c);
            }
            
        }

        public ActionResult CeviriKontrol(int id)
        {
            var c = db.Ceviri.Find(id);
            return View(c);
        }

    }
}