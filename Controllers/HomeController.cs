using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clinic_admin.Models;

namespace clinic_admin.Controllers
{
    
    public class HomeController : Controller
    {
        hdata context = new hdata();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCmmn()
        {
            try
            {
                var res = context.tblCommon.Select(x => new { x.pkID, x.name, x.itmContent, x.description }).ToList();
                return Json(new { state = true, m = res }, JsonRequestBehavior.AllowGet);

            }
            catch(Exception e)
            {
                return Json(new { state = false, m = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}