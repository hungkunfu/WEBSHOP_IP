using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopIP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<WebShopIP.Entities.Order> Orders { get; set; }

        public List<WebShopIP.Entities.Category> Categories { get; set; }
        public List<WebShopIP.Entities.Product> Products { get; set; }


    }
}
