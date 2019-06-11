using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSimECommerce.Entities;
using RestSimECommerce.Web.Data;

namespace RestSimECommerce.Web.Controllers
{
    public class ImageProductsController : Controller
    {
        private readonly RestSimECommerceContext _context;
        public ImageProductsController(RestSimECommerceContext restSimECommerceContext)
        {
            _context = restSimECommerceContext;
        }

        [HttpGet]
        public FileStreamResult ViewImage(int? id)
        {

            Picture picture = _context.Picture.FirstOrDefault(p => p.Id == id);
            MemoryStream ms = new MemoryStream(picture.PictureBinary);
            return new FileStreamResult(ms, picture.MimeType);

        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}