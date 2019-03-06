using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crm.Wep.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        
        public ActionResult Index()
        {
            return View();
        }
    }
}