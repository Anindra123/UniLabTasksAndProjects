using ADV_Prog.NET_LAB__2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADV_Prog.NET_LAB__2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product p1 = new Product();
                p1.Id = i + 1;
                p1.ProductName = $"Product {i + 1}";
                p1.Price = 1000.0 + (i+1);
                products.Add(p1);
            }
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                TempData["Id"] = p.Id;
                TempData["name"] = p.ProductName;
                return RedirectToAction("Index");
            }
            return View(p);
        }




    }
}