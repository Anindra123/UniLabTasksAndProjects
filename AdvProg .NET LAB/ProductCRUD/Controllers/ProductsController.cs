using ProductCRUD.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCRUD.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var db = new ProductDBEntities();
            var productList = db.Products.ToList();
            return View(productList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            var db = new ProductDBEntities();
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var db = new ProductDBEntities();


            var product = (from p in db.Products
                           where p.id == id
                           select p).SingleOrDefault();

            db.Products.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new ProductDBEntities();


            var product = (from p in db.Products
                           where p.id == id
                           select p).SingleOrDefault();

            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product np)
        {
            var db = new ProductDBEntities();


            var product = (from p in db.Products
                           where p.id == np.id
                           select p).SingleOrDefault();

            product.Name = np.Name;
            product.Price = np.Price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}