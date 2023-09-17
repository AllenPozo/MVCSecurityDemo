using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSecurityDemo.Controllers
{
    [Authorize(Users ="grace.hernandez@upes.edu.sv")]
    public class SecretController : Controller
    {
        // GET: Secret
        public ActionResult Index()
        {
            return View();
        }

      // [Authorize]
        public ContentResult Secret()
        {
            return Content("Secret information");
        }

        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Secret information here");
        }

    }
}