using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Models;

namespace WebShopIP.Services
{
    public class SqlServices : ISerices
    {
        private UserManager<ApplicationUser> usermanager;
        private AppDbContexts context;
        private RoleManager<IdentityRole> roleManager;
        public SqlServices(AppDbContexts context,
                           UserManager<ApplicationUser> usermanager,
                           RoleManager<IdentityRole> roleManager)
        {
            this.usermanager = usermanager;
            this.context = context;
            this.roleManager = roleManager;
        }

        public List<Role> GetsRole(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetsUser(string keyword)
        {
            var users = context.Users.ToList();
            var viewUsers = new List<UserViewModel>();
            if (!string.IsNullOrEmpty(keyword))
            {
                viewUsers = (from e in users
                                 where e.Email.ToLower().Contains(keyword.ToLower())
                                 select new UserViewModel()
                                 {
                                     City = e.City,
                                     Address = e.Address,
                                     Email = e.Email,
                                     UserId = e.Id
                                 }).ToList();
            }
            else
            {
                viewUsers = (from e in users
                             select new UserViewModel()
                                 {
                                     City = e.City,
                                     Address = e.Address,
                                     Email = e.Email,
                                     UserId = e.Id
                                 }).ToList();
            }
            foreach (var item in viewUsers)
            {
                item.RoleName = GetRolesName(item.UserId);
            }

            return viewUsers;
        }
        public string GetRolesName(string userId)
        {
            var user = Task.Run(async () => await usermanager.FindByIdAsync(userId)).Result;
            var roles = Task.Run(async () => await usermanager.GetRolesAsync(user)).Result;
            return roles != null ? string.Join(", ", roles) : string.Empty;

        }
    }
}
