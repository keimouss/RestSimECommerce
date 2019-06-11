using Microsoft.AspNetCore.Mvc;
using RestSimECommerce.Entities;
using RestSimECommerce.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestSimECommerce.ViewComponents
{
    public class MenuCategoryViewComponent:ViewComponent
    {
        private readonly RestSimECommerceContext _context;
        public MenuCategoryViewComponent(RestSimECommerceContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var _categories = _context.Category.Where(c => c.ParentCategoryId == 0).ToList();
            return View(_categories);
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var parentsCategory = await GetCategoriesParent();
        //    return View("_MenuCategory", parentsCategory);
        //}

        private async Task<List<Category>> GetCategoriesParent()
        {
           Task<List<Category>> categories=Task.Run(() => _context.Category.Where(c => c.Id == 0).ToList());
           
            return await categories;
        }
    }
}
