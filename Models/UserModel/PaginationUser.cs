using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;

namespace WebShopIP.Models.UserModel
{
    public class PaginationUser
    {
        public List<UserViewModel> UserViewModels { get; set; }
        public PaginationUsers paginationUsers { get; set; }
    }
}
