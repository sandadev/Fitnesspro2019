using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Infrastructure.Models;

namespace Fitnesspro.Infrastructure.Interface.DataAccess
{
    public interface IServiceGroupRepository
    {
        List<servicegroup> ServiceGroupList();
    }
}
