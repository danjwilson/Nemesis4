using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Nemesis.Site.Models;
using Nemesis.Core;

namespace Nemesis.Site.Controllers
{
    public class StoreController : Controller
    {
        private readonly IRepository _repo;

        public StoreController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult List(SearchViewModel req)
        {
            return RedirectToAction("List", "Store", new { Area = req.PostcodeSearchValue });
        }

        [HttpGet]
        public IActionResult List(string Area, string ProductType)
        {
            if (Area != null && ProductType == null)
                return View(new StoreListViewModel(_repo.Stores.Where(s => s.Postcode.ToLower().StartsWith(Area.Substring(0, 3).ToLower()))));
            else
                return View(new StoreListViewModel(_repo.Stores));
        }

        [HttpGet]
        public IActionResult Detail(string Id)
        {
            var item = new StoreDetailViewModel(_repo.Stores.First(s => s.Id.Equals(Id)));
            return View(item);
        }

        [HttpPost]
        public IActionResult Detail(StoreDetailViewModel model)
        {
            var item = _repo.Stores.First(s => s.Id.Equals(model.Id));
            item.Name = model.Name;
            item.OpeningHours = model.OpeningHours;
            item.Postcode = model.Postcode;

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}
