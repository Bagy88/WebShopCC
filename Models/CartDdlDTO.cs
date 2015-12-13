using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopCC.Models
{
    public class CartDdlDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}