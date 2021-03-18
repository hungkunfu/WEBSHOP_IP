using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Repositories;

namespace WebShopIP.RepositoryApp
{
    public class CustomerRepository: ICustomerInfoRepository
    {
        private readonly AppDbContexts context;

        public CustomerRepository(AppDbContexts context)
        {
            this.context = context;
        }
        public int CreateInfoCustomer(InfoCustomer infoCustomer)
        {
            context.Add(infoCustomer);
            return context.SaveChanges();
        }

        public InfoCustomer GetInfoCustomerById(int id)
        {
            return context.InfoCustomers.FirstOrDefault(el => el.Id == id);
        }
    }
}
