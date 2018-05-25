using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using UI.Models;
using PagedList;

namespace UI.Controllers
{
    public class Special2Controller : Controller
    {
        FoodsEntities db = new FoodsEntities();
        SpecialManager specialmanager = new SpecialManager();
        FoodManager foodManager = new FoodManager();
        // GET: Special2
        public ActionResult FoodSpecial(String genreInfoFrom, string currentFilter, int? page)
        {
            var foods = foodManager.GetFood();
            if (genreInfoFrom != null)
            {
                page = 1;
            }
            else
            {
                genreInfoFrom = currentFilter;
            }
            ViewBag.CurrentFilter = genreInfoFrom;
            if (!String.IsNullOrEmpty(genreInfoFrom))
            {
                foods = foods.Where(x => x.Special.SpecialName == genreInfoFrom);
            }
            int pageSize = 18;
            int pageNumber = (page ?? 1);
            return View(foods.ToPagedList(pageNumber, pageSize));
        }
    }
}