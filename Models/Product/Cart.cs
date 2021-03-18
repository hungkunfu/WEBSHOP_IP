using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopIP.Models.Product
{
    public class Cart
    {
        public int Quantity { get; set; }
        public WebShopIP.Entities.Product Product { get; set; }
    }
}
