using System.Linq;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Nemesis.Core;
using Nemesis.Site.Models;

namespace Nemesis.Site.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _repo;

        public ProductController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult List(string postcode = "", string product = "")
        {
            return View(new StoreProductListViewModel(_repo.StoreProducts.Where(p => 
                p.Store.Postcode.ToLower().StartsWith(postcode.ToLower()) && p.Product.Name.ToLower().Contains(product.ToLower()))));
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            return View(new ProductDetailViewModel(_repo.Products.First(p => p.Id.Equals(Id))));
        }

        [HttpPost]
        public IActionResult Detail(StoreDetailViewModel model)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}