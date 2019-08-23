using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitnesspro.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        [Route("Services")]
            [HttpGet]
        public ActionResult List()
        {
            return View();
        }
    }
}