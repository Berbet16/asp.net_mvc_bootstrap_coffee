using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("urunler")]
        public ActionResult Urunler()
        {
            return View();
        }
        [Route("magaza")]
        public ActionResult Magaza()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}