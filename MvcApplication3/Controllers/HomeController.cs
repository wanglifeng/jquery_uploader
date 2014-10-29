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
            var content = String.Format("File Count:{0}", Request.Files.Count);
            if(Request.Files.Count>0)
                content += string.Format(" file Name:{0}",Request.Files[0].FileName);
            return new JsonResult() { Data = content };
        }

    }
}
