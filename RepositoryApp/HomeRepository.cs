using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Repositories;

namespace WebShopIP.RepositoryApp
{
    public class HomeRepository:IHomeRepository
    {
        private readonly AppDbContexts context;

        public HomeRepository(AppDbContexts context)
        {
            this.context = context;
        }
        public List<Category> Categories => context.Categories.ToList().FindAll(el => el.Status == Enum.Status.Active);

        public List<Product> GetProductsByCateId(int id) =>
            context.Products.ToList().FindAll(el => el.CategoryId == id && el.Status == Enum.Status.Active);
    }
}
