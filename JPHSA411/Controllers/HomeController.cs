using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPHSA411.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult IT_Dept()
        //{
        //    //ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult SysAid_Incident()
        //{

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}