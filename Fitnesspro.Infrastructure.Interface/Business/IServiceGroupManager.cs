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
            List<servicegroup> ServiceGroupList();
        }
}
