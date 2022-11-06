using Microsoft.AspNetCore.Mvc;

namespace webCalculator.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculator(string firstNum, string secondNum)
        {
            double first = double.Parse(firstNum);
            double second = double.Parse(secondNum);
            
            double firstsqrt = Math.Sqrt(first);
            double secondsqrt = Math.Sqrt(second);

            ViewBag.FirstNumSqrt = firstsqrt;
            ViewBag.SecondNumSqrt = secondsqrt;
            return View();
        }
    }
}
