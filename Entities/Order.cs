using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Enum;
using WebShopIP.Models;

namespace WebShopIP.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public PayStatus PayStatus { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ShipperDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public string CreateBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int InfoCustomerId { get; set; }
    }
}
