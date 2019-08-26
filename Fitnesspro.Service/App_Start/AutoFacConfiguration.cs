using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Reflection;
using Fitnesspro.Infrastructure.Interface.Business;
using Fitnesspro.Infrastructure.Interface.DataAccess;
using Fitnesspro.Repository.Repos;
using Fitnesspro.Business;
using System.Data.Entity;
using Fitnesspro.Repository;

namespace Fitnesspro.Service
{
    public class AutoFacConfiguration
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<FitnessProEntities>().As<DbContext>().InstancePerRequest();

            // Business
            builder.RegisterType<ServiceGroupManager>().As<IServiceGroupManager>();
            //builder.RegisterType<UserManager>().As<IUserManager>();

            // Repository
            //builder.RegisterType<UserRepository>().As<IServiceGroupRepository>();
            builder.RegisterType<ServicegroupRepository>().As<IServiceGroupRepository>();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}
