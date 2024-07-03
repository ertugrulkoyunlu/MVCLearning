using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Senin hakkinda sayfan.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Senin Iletisim Sayfan.";

            return View();
        }
        public ActionResult Bilgi()
        {

            return View();
        }
        public ActionResult Profilim()
        {
            return View();
        }
    }
}