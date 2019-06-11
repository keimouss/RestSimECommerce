using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSimECommerce.Application.ViewModels.CatalogViewModel;
using RestSimECommerce.Entities;
using RestSimECommerce.Web.Data;
using RestSimECommerce.Web.Tools;

namespace RestSimECommerce.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly RestSimECommerceContext _context;
        public const string SessionPanier = "_Panier";

        public CatalogController(RestSimECommerceContext restSimECommerceContext)
        {
            _context = restSimECommerceContext;
        }
        public IActionResult GetCategorie(int? id)
        {
            //récuperer tous les identifiants des pictures à l'aide de l'id du ParentCategorie
            if (id == null)
            {
                return new BadRequestResult();
            }
            var categorielist = _context.Category.Where(c => c.ParentCategoryId == id).ToList();
            ViewBag.categorielist = categorielist;

            return PartialView("_CategoryDropdownList", categorielist);
        }

        public IActionResult GetCategorie2(int? id)
        {
            //récuperer tous les identifiants des pictures à l'aide de l'id du ParentCategorie
            if (id == null)
            {
                return new BadRequestResult();
            }
            var categorielist = _context.Category.Where(c => c.ParentCategoryId == id).ToList();
            ViewBag.categorielist = categorielist;

            return PartialView("_hpCategoryGrid", categorielist);
        }

        public PartialViewResult Products(int? id)
        {
            //récuperer tous les identifiants des pictures à l'aide de l'id de la catégorie
            var result = (from r in _context.ProductCategoryMapping
                          where r.CategoryId == id
                          select r.Product).ToList();
            foreach (var product in result)
            {
                var pPictureMapping = (from ppm in _context.ProductPictureMapping
                                       where ppm.ProductId == product.Id
                                       select ppm).ToList();
                ViewBag.Pictures = pPictureMapping;

            }
            ViewBag.Products = result;
            var p = result.FirstOrDefault();


            //return PartialView("_Products", result);
            return PartialView("_ProductGrid", result);
        }



        public IActionResult GetProduct(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            var result = (from r in _context.ProductCategoryMapping
                          where r.CategoryId == id
                          select r.Product).ToList();

            var prodlist = (from p in result
                            select p.Name).ToList();

            return Json(prodlist);
        }

        [HttpGet]
        public IActionResult LePanier()
        {
            var ListeProducts = _context.Product.ToList();
            Panier panier = HttpContext.Session.Get<Panier>(SessionPanier);
            if (panier == null)
            {
                return new BadRequestResult();
            }
            var panierProducts = new List<Product>();
            foreach (var ligne in panier.Lignes)
            {
                panierProducts = ListeProducts.Where(p => p.Id == ligne.IdProduit).ToList();
            }
            return View("LePanier", panierProducts);
        }

        [HttpPost]
        public IActionResult AjoutPanier(int id)
        {
            var leproduct = _context.Product.FirstOrDefault(p => p.Id == id);
            if (leproduct == null)
            {
                return new BadRequestResult();
            }
            Panier panier = HttpContext.Session.Get<Panier>(SessionPanier);

            if (panier == null)
            {
                panier = new Panier();
            }

            panier.Add(new Panier.Ligne()
            {
                IdProduit = leproduct.Id,
                NomProduit = leproduct.Name,
                Prix = leproduct.Price,
                Quantite = 1
            });

            HttpContext.Session.Set(SessionPanier, panier);


            return new JsonResult(panier);
        }
    }
}