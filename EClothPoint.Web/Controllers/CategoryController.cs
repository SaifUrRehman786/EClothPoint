using EClothPoint.Entities;
using EClothPoint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EClothPoint.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryTabble(string search)
        {
            var categories = categoriesService.GetAllCategories();

            if (!string.IsNullOrEmpty(search))
            {
                categories = categories.Where(c => c.Name != null && c.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(categories);
        }


        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoriesService.SaveCategory(category);

            return RedirectToAction("CategoryTabble");
        }

        public ActionResult Edit(int ID)
        {
            var category = categoriesService.GetCategory(ID);

            return PartialView(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoriesService.UpdateCategory(category);

            return RedirectToAction("CategoryTabble");
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            categoriesService.DeleteCategory(ID);

            return RedirectToAction("CategoryTabble");
        }
    }
}