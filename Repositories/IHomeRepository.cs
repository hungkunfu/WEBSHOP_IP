using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Repositories
{
   public interface IHomeRepository
    {
        List<Category> Categories { get; }

        List<Product> GetProductsByCateId(int id);
    }
}
