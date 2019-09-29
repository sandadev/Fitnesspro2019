using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Infrastructure.Models;


namespace Fitnesspro.Infrastructure.Interface.Business
{ 
        public interface IServiceGroupManager
        {
        List<ServiceViewModel> ServiceGroupList();
        ValidateResponse UpdateServiceGroup(int id, ServiceViewModel servicegroup);
        ValidateResponse CreateNewServiceGroup(servicegroup serviceGroup);
        ValidateResponse DeleteServiceGroup(int id);

    }
}
