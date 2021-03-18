using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Repositories
{
    public interface ICustomerInfoRepository
    {
        public int CreateInfoCustomer(InfoCustomer infoCustomer);

        public InfoCustomer GetInfoCustomerById(int id);
    }
}
