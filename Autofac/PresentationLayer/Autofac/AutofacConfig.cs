using Autofac;
using Autofac.Integration.Mvc;
using BL.Interfaces;
using BL.Managers;
using DAL;
using DAL.Interfaces;
using System.Web.Mvc;

namespace PresentationLayer.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<AnimalsContext>().InstancePerRequest();
            builder.RegisterType<AnimalsManager>().As<IAnimalsManager>();
            builder.RegisterType<AnimalsRepository>().As<IAnimalsRepository>();

            builder.RegisterModule<AutofacModule>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
    }
