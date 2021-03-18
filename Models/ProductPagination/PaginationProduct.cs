using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Models.ProductPagination
{
    public class PaginationProduct
    {
        public List<WebShopIP.Entities.Product> products { get; set; }
        public Pagination Pagination { get; set; }
    }
}
