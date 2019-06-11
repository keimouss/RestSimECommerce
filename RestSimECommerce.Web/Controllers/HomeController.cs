using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSimECommerce.Application.ViewModels.HomeViewModel;
using RestSimECommerce.Web.Data;
using RestSimECommerce.Web.Models;

namespace RestSimECommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestSimECommerceContext _context;

        public HomeController(RestSimECommerceContext restSimECommerceContext)
        {
            _context = restSimECommerceContext;
        }
        
        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();
            IndexViewModel.Categories = _context.Category.ToList();
            IndexViewModel.Products = _context.Product.ToList();
            indexViewModel.CategorieParents = IndexViewModel.Categories.Where(c => c.ParentCategoryId == 0).ToList();
            indexViewModel.CategoriesHomePageList = IndexViewModel.Categories.Where(c => c.ShowOnHomePage == true).ToList();

            indexViewModel.ProductHomePageList = IndexViewModel.Products.Where(p => p.ShowOnHomePage == true).ToList();
            ViewBag.parentcategories = indexViewModel.CategorieParents;
            return View(indexViewModel);
        }
        [HttpGet]
        public IActionResult SousCategory(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            var SousCategoriesHomePages = IndexViewModel.Categories.Where(c => c.Id == id).ToList();
            return PartialView("_hpCategoryGrid", SousCategoriesHomePages);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
