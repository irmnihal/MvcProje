using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // sadece category e özel controller burada tutulacak 
        // tablo kullanımı göstericez

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}