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
    class ServiceGroupManager : IServiceGroupManager
    {
        private IServiceGroupRepository _servicegrouprepository;
        public ServiceGroupManager(IServiceGroupRepository servicegrouprepository)
        {
            _servicegrouprepository = servicegrouprepository;
        }
        public List<servicegroup> ServiceGroupList()
        {
          return  _servicegrouprepository.ServiceGroupList();
        }
    }
}
