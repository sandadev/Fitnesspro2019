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

        public ValidateResponse CreateNewServiceGroup(servicegroup serviceGroup)
        {
            return _servicegrouprepository.CreateNewServiceGroup(serviceGroup);
        }

        public ValidateResponse DeleteServiceGroup(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceViewModel> ServiceGroupList()
        {
          return  _servicegrouprepository.ServiceGroupList();
        }

        public ValidateResponse UpdateServiceGroup(int id)
        {
            throw new NotImplementedException();
        }

        public ValidateResponse UpdateServiceGroup(int id, ServiceViewModel servicegroup)
        {
            throw new NotImplementedException();
        }
    }
}
