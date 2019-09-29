using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fitnesspro.Infrastructure.Models;
using Fitnesspro.Infrastructure.Interface.DataAccess;
using Fitnesspro.Repository;
using System.Collections;
using System.Security.Cryptography;

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
                //var result = serviceGroup.GroupBy(x => x.ServiceGroupId);

              


                //List<ServiceViewModel> serviceGroup = (from sg in context.ServiceGroups
                //                                       group sg by sg.GroupName into sgg
                //                                       join s in context.Services on sgg.FirstOrDefault().ServiceGroupId equals s.ServiceGroupId
                //                                       select new ServiceGroupList<string, ServiceViewModel>
                //                                       {
                //                                           ServiceGroupName = sgg.Key,

                //                                       }).ToList();
                //var result = serviceGroup.GroupBy(x => x.ServiceGroupId);

                //var test = (from sg in context.ServiceGroups
                //            join s in context.Services on sg.ServiceGroupId equals s.ServiceGroupId
                //            select new ServiceGroupList<string,ServiceViewModel>
                //            {
                //                ServiceGroupName = sg.GroupName,
                //               SeriveList=
                //            })
                //            .GroupBy(x => x.GroupName)
                //            .ToList();

                //List < servicegroup > mServicegroup = iMapper.Map<List<ServiceGroup>, List<ServiceViewModel>>(serviceGroup);
                //    return mServicegroup;

                return serviceGroup;
                }
            
        }

        public ValidateResponse CreateNewServiceGroup(servicegroup serviceGroup)
        {
            ValidateResponse resposne = new ValidateResponse();
            try
            {
                using (var context =new FitnessProEntities()) {

                    IMapper iMapper = revMapConfig.CreateMapper();
                    ServiceGroup eServiceGroup = new ServiceGroup();
                    iMapper.Map(serviceGroup, eServiceGroup);
                    context.ServiceGroups.Add(eServiceGroup);
                    context.SaveChanges();
                    resposne.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {

                resposne.IsSuccess = false;
                resposne.ValidationMessages = new List<string> { ex.ToString() };
            }

            return resposne;
        }

        public ValidateResponse DeleteServiceGroup(int id)
        {
            throw new NotImplementedException();
        }

        public ValidateResponse UpdateServiceGroup(int id, ServiceViewModel servicegroup)
        {
            throw new NotImplementedException();
        }
    }
}
