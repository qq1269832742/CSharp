using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Logic.Installers;
using Repository.Installers;

namespace CastleDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var windsorContainer = new WindsorContainer();

            windsorContainer.Install(FromAssembly.This(),
                FromAssembly.Containing<HelloWorldLogicInstaller>(),
                FromAssembly.Containing<HelloWorldRepositoryInstaller>());
         
            var controllerFactory = new WindsorControllerFactory(windsorContainer.Kernel);
            windsorContainer.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestylePerWebRequest());
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            windsorContainer.Register(Component.For<IWindsorContainer>().Instance(windsorContainer).LifestyleSingleton());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
