using Microsoft.AspNetCore.Mvc;

namespace ZeissMVCDemo.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Demo(int id)
        {
            Console.WriteLine($"Code is: {id}");
            return View();
        }

    }
}
