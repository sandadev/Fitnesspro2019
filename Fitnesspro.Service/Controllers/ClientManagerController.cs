using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fitnesspro.Infrastructure.Interface.Business;
using Fitnesspro.Infrastructure.Models;

namespace Fitnesspro.Service.Controllers
{
    [RoutePrefix("api/Client")]
    public class ClientManagerController : ApiController
    {
        private IServiceGroupManager _serviceGroupManager;
    }
}
