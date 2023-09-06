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
		public IActionResult Page()
		{
			return View();
		}
		public IActionResult Pricing()
		{
			return View();
		}
		public IActionResult FAQ()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
	}
}
