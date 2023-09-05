using Microsoft.AspNetCore.Mvc;

namespace Excel_On.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult Service()
		{
			return View();
		}
	}
}
