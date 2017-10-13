using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GummiBear.Controllers
{
    public class CategoryController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();

        public IActionResult Index()
        {
            ViewBag.AllCategories = db.Categories.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category Category)
        {
            db.Categories.Add((Category));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int CategoryId)
        {
            var thisCategory = db.Categories.FirstOrDefault(Category => Category.CategoryId == CategoryId);
            return View(thisCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int CategoryId)
        {
            var thisCategory = db.Categories.FirstOrDefault(Category => Category.CategoryId == CategoryId);
            db.Categories.Remove(thisCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int CategoryId)
        {
            var thisCategory = db.Categories
                   .Include(x => x.Products)
                   .FirstOrDefault(x => x.CategoryId == CategoryId);

            return View(thisCategory);
        }

        public IActionResult Update(int CategoryId)
        {
            var thisCategory = db.Categories.FirstOrDefault((Category => Category.CategoryId == CategoryId));
            return View(thisCategory);
        }

        [HttpPost]
        public IActionResult Update(Category Category)
        {

            db.Entry(Category).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}