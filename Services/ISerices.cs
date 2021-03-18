using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Services
{
  public  interface ISerices
    {
        public List<Role> GetsRole(string keyword);
        public List<UserViewModel> GetsUser(string keyword);
       
    }
}
