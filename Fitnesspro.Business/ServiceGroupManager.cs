using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Infrastructure.Models;
using Fitnesspro.Infrastructure.Interface.Business;
using Fitnesspro.Infrastructure.Interface.DataAccess;

namespace Fitnesspro.Business
{
   public class ServiceGroupManager : IServiceGroupManager
    {
        private IServiceGroupRepository _servicegrouprepository;
        public ServiceGroupManager(IServiceGroupRepository servicegrouprepository)
        {
            _servicegrouprepository = servicegrouprepository;
        }
        public List<ServiceViewModel> ServiceGroupList()
        {
          return  _servicegrouprepository.ServiceGroupList();
        }
    }
}
