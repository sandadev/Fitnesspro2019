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
            cfg.CreateMap<ServiceGroup, ServiceViewModel>();
        });
        MapperConfiguration revMapConfig = new MapperConfiguration(cfg => {
            cfg.CreateMap<ServiceViewModel, ServiceGroup>();
        });

        public List<ServiceViewModel> ServiceGroupList()
        {
                using (var context = new FitnessProEntities())
                {
                IMapper iMapper = config.CreateMapper();
                List<ServiceViewModel> serviceGroup = (from sg in context.ServiceGroups
                                                       group sg by sg.ServiceGroupId into sgg
                                                       join s in context.Services on sgg.FirstOrDefault().ServiceGroupId equals s.ServiceGroupId
                                                       select new ServiceViewModel
                                                       {
                                                           ServiceGroupId = sgg.FirstOrDefault().ServiceGroupId,
                                                           GroupName = sgg.FirstOrDefault().GroupName,
                                                           ServiceId = s.ServiceId,
                                                           ServiceName = s.ServiceName
                                                       }).ToList();




                //List < servicegroup > mServicegroup = iMapper.Map<List<ServiceGroup>, List<ServiceViewModel>>(serviceGroup);
                //    return mServicegroup;

                return serviceGroup;
                }
            
        }
    }
}
