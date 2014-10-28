using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return new JsonResult() { Data = String.Format("File Count:{0}", Request.Files.Count) };
        }

    }
}
