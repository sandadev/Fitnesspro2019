using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitnesspro.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        [Route("ClientList")]
        public ActionResult List()
        {
            return View();
        }
    }
}