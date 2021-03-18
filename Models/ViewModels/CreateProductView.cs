
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Enum;

namespace WebShopIP.Models.ViewModels
{
    public class CreateProductView
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public IFormFile IformfilePath { get; set; }
        public Status Status { get; set; }

        public int CategoryId { get; set; }
    }
}
