using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fitnesspro.Infrastructure.Models;
using Fitnesspro.Infrastructure.Interface.DataAccess;
using Fitnesspro.Repository;

namespace Fitnesspro.Repository.Repos
{

  public  class ServicegroupRepository :IServiceGroupRepository
    {
        public ServicegroupRepository()
        {

        }

        MapperConfiguration config = new MapperConfiguration(cfg => {
            cfg.CreateMap<ServiceGroup, servicegroup>();
        });
        MapperConfiguration revMapConfig = new MapperConfiguration(cfg => {
            cfg.CreateMap<servicegroup, ServiceGroup>();
        });

        public List<servicegroup> ServiceGroupList()
        {
                using (var context = new FitnessProEntities())
                {
                    IMapper iMapper = config.CreateMapper();
                List<ServiceGroup> serviceGroup = context.ServiceGroups.ToList();
                    List<servicegroup> mServicegroup = iMapper.Map<List<ServiceGroup>, List<servicegroup>>(serviceGroup);
                    return mServicegroup;
                }
            
        }
    }
}
