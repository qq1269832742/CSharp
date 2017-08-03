using System.Web.Mvc;
using CastleDemo.Models;
using ILogics;

namespace CastleDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly IHelloWorldLogic _helloWorldLogic;
        private readonly ITestCastleLogic _testCastleLogic;
        public HelloWorldController(IHelloWorldLogic helloWorldSerevice, ITestCastleLogic testCastleLogic)
        {
            _helloWorldLogic = helloWorldSerevice;
            _testCastleLogic = testCastleLogic;
        }

        // GET: HelloWorld
        public ActionResult Index()
        {
            var helloWorldViewModelInterface = new HelloWorldViewModel
            {
                Content = _helloWorldLogic.SayHelloById("1")
            };

            //var helloWorldViewModelInterface = new HelloWorldViewModel
            //{
            //    Content = _testCastleLogic.GetName()
            //};

            return View(helloWorldViewModelInterface);
        }
    }
}