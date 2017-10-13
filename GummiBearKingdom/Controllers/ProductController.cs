using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using GummiBearKingdom.Models;

namespace GummiBearKingdom.Controllers
{
    public class ProductController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();


        public IActionResult Index()
        {
            ViewBag.AllProducts = db.Products.ToList();
            return View();
        }

        public IActionResult Create(int CategoryId)
        {
            var thisCategory = db.Categories.FirstOrDefault(Category => Category.CategoryId == CategoryId);
            ViewBag.thisCategory = thisCategory;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product Product)
        {
            db.Products.Add(Product);
            db.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

        public IActionResult Details(int ProductId)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == ProductId);
            ViewBag.Category = db.Categories.FirstOrDefault(Category => Category.CategoryId == thisProduct.CategoryId); ;
            return View(thisProduct);
        }

        public IActionResult Delete(int ProductId)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == ProductId);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int ProductId)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == ProductId);
            ViewBag.Category = db.Categories.FirstOrDefault(Category => Category.CategoryId == thisProduct.CategoryId);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Details", "Category", new { CategoryId = thisProduct.CategoryId });
        }

        public IActionResult Update(int ProductId)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == ProductId);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Update(Product Product)
        {

            db.Entry(Product).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Details", "Product", new { ProductId = Product.ProductId });
        }

    }
}