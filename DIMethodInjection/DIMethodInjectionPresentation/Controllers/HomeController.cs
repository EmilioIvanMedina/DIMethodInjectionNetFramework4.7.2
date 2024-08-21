using DIMethodInjectionSampleService.Interfaces;
using System.Web.Mvc;

namespace DIMethodInjectionPresentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ISampleService _sampleService = (ISampleService)DependencyResolver.Current.GetService(typeof(ISampleService));
            var myName = _sampleService.GetName();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}