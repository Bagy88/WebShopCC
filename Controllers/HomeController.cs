using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopCC.Models;

namespace WebShopCC.Controllers
{
    public class HomeController : Controller
    {
        private WebShopCC_Entities db = new WebShopCC_Entities();

        public ActionResult Index()
        {
            HomePageViewModel hpvm = new HomePageViewModel();
            hpvm.Products = db.Product.ToList();
            hpvm.Categories = db.Category.ToList();
            var cart = ShoppingCart.GetCart(this);
            hpvm.CartID = cart.ShoppingCartId;

            ViewBag.SessionID = cart.ShoppingCartId;

            return View(hpvm);
        }

        public ActionResult HomeResult(int? categoryid)
        {
            IEnumerable<Product> product_list = null;
            if (categoryid.HasValue)
            {
                product_list = db.Product
                .Where(x => x.IDCategory == categoryid.Value)
                .ToList();
            }
            else
            {
                product_list = db.Product.ToList();
            }

            return PartialView("_HomeResult", product_list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}