﻿using Microsoft.AspNetCore.Mvc;
using webCalculator.Models;

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
        public IActionResult proddta(ProductData product)
        {
            using (var proddb = new ModelsContext()) { 
                proddb.Add(product);
                proddb.SaveChanges();
            }


         /*   ViewBag.prod_ID = productID;
            ViewBag.prod_Title = productTitle;
            ViewBag.prod_Description = productDescription;
            ViewBag.prod_Quantity = productQuantity;
            ViewBag.prod_Brand = productBrand;
            ViewBag.prod_Category = productCategory;
            ViewBag.prod_Price = productPrice;*/
            return View();
        }

    }
}
