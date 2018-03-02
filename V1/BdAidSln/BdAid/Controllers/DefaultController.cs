using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BdAid.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        public ActionResult LoginView()
        {
            return View();
        }

        public ActionResult ContactView()
        {
            return View();
        }
	}
}