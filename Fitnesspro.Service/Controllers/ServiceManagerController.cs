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
    [RoutePrefix("api/Services")]
    public class ServiceManagerController : ApiController
    {
        private IServiceGroupManager _serviceGroupManager;
      
        public ServiceManagerController(IServiceGroupManager serviceGroupManager)
        {
            _serviceGroupManager = serviceGroupManager;
        }
      
        [Route("ServiceGroupList")]
        [HttpGet]
        public List<servicegroup> TotalServiceGroupList()
        {
            return _serviceGroupManager.ServiceGroupList();
        }
    }
}
