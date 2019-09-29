using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
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
        public List<ServiceViewModel> TotalServiceGroupList()
        {
            return _serviceGroupManager.ServiceGroupList();
        }

        [Route("CreateServiceGroup")]
        [HttpPost]
        public HttpStatusCode CreateNewServiceGroup([FromBody]servicegroup serviceGroup)
        {
            if (ModelState.IsValid)
            {
                ValidateResponse response = _serviceGroupManager.CreateNewServiceGroup(serviceGroup);
                if (response.IsSuccess)
                {
                    return HttpStatusCode.Created;
                }
            }
            return HttpStatusCode.BadRequest;
        }

        [Route("UpdateServiceGroup")]
        [HttpPut]
        public HttpStatusCode Put(int id, [FromBody]servicegroup serviceGroup)
        {
            throw new NotImplementedException("");
        }

    }
}
