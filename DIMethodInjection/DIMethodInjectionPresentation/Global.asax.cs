using DIMethodInjectionPresentation.App_Start;
using DIMethodInjectionSampleService.Implementations;
using DIMethodInjectionSampleService.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DIMethodInjectionPresentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static ServiceProvider ServiceProvider;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var services = new ServiceCollection();

            services.AddTransient<ISampleService, SampleService>();

            ServiceProvider = services.BuildServiceProvider();

            DependencyResolver.SetResolver(new ServiceProviderDependencyResolver(ServiceProvider));
        }
    }
}
