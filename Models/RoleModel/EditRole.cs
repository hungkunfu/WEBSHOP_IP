using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopIP.Models.RoleModel
{
    public class EditRole
    {
        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
