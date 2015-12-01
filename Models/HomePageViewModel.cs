using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopCC.Models
{
    public class HomePageViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}