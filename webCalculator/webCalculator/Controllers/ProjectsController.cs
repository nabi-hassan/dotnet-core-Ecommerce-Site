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

        [HttpGet]
        public IActionResult proddta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult proddta(string Product_ID, string Product_Title, string Product_Description, string Product_Quantity, string Product_Brand, string Product_Category, string Product_Price)
        {
            string productID = Product_ID;
            string productTitle = Product_Title;
            string productDescription = Product_Description;
            string productQuantity = Product_Quantity;
            string productBrand = Product_Brand;
            string productCategory = Product_Category;
            string productPrice = Product_Price;


            ViewBag.prod_ID = productID;
            ViewBag.prod_Title = productTitle;
            ViewBag.prod_Description = productDescription;
            ViewBag.prod_Quantity = productQuantity;
            ViewBag.prod_Brand = productBrand;
            ViewBag.prod_Category = productCategory;
            ViewBag.prod_Price = productPrice;
            return View();
        }

    }
}
