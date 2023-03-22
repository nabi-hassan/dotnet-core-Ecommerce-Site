using Microsoft.AspNetCore.Mvc;
using webCalculator.Models;

namespace webCalculator.Controllers
{
    public class ProductsCRUDController : Controller
    {


        public IActionResult DisplayProduct()
        {
            List<ProductData> products = new List<ProductData>();

            using (var db = new ModelsContext())
            {
                products = db.Products.ToList();
            }

            ViewBag.prods = products;

            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductData product)
        {
            using (var proddb = new ModelsContext())
            {
                proddb.Add(product);
                proddb.SaveChanges();
            }

            List<ProductData> products = new List<ProductData>();

            using (var db = new ModelsContext())
            {
                products = db.Products.ToList();
            }

            ViewBag.prods = products;
            return View();
        }
        public IActionResult UpdateProduct(ProductData product)
        {
            using (var proddb = new ModelsContext())
            {
                var TempProd = proddb.Products.Where(p => p.ProdId == product.ProdId).FirstOrDefault();
                TempData["prodTemp"] = TempProd;
            }
            return View();
        }

        public IActionResult DeleteProduct(ProductData product)
        {
            var Prod = new ProductData() { ProdId = product.ProdId} ; 
            using (var proddb = new ModelsContext())
            {
                proddb.Attach(Prod);
                proddb.Remove(Prod);
                proddb.SaveChanges();
            }
            return View("DisplayProduct");
        }

        public IActionResult UpdateProductFinal(ProductData product)
        {
            using (var proddb = new ModelsContext())
            {
                var existingProduct = proddb.Products.Where(p => p.ProdId == product.ProdId).FirstOrDefault();
                
                existingProduct.ProdTitle = product.ProdTitle;
                existingProduct.ProdDescription = product.ProdDescription;
                existingProduct.ProdQuantity = product.ProdQuantity;
                existingProduct.ProdBrand = product.ProdBrand;
                existingProduct.ProdCategory = product.ProdCategory;
                existingProduct.ProdPrice = product.ProdPrice;

                proddb.SaveChanges();
            }
            return View("DisplayProduct");
        }
    }


}
