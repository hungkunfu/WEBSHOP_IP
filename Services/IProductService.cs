using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Services
{
    public interface IProductService
    {
        public List<Product> Gets();
        public Product Get(int productId);
        //public SaveResponse Save(SaveRequest request);
    }
}
