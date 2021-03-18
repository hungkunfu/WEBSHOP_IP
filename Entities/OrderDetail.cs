using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Enum;

namespace WebShopIP.Entities
{
    public class OrderDetail
    {
        [Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double UnitPrice { get; set; }
        public PayStatus PayStatus { get; set; }
    }
}
