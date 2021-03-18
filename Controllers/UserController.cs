using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopIP.Entities;
using WebShopIP.Models;
using WebShopIP.Models.UserModel;
using WebShopIP.Services;

namespace WebShopIP.Controllers
{
    //[Authorize(Roles = "System Adminstaror")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> usermanager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public ISerices sericess;


        public UserController(UserManager<ApplicationUser> usermanager,
                 SignInManager<ApplicationUser> signInManager,
                 RoleManager<IdentityRole> roleManager,
                 ISerices sericess)
        {
            this.usermanager = usermanager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.sericess = sericess;

        }

        public IActionResult Index(int? pageNumber, int? pageSize, string keyword)
        {
            var employees = sericess.GetsUser(keyword).OrderByDescending(e => e.UserId).ToList();
            var pagination = new PaginationUsers(employees.Count, pageNumber, pageSize, keyword);
            var viewModel = new PaginationUser()
            {
                UserViewModels = employees.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
                paginationUsers = pagination
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                   
                    Email = model.Email,
                    UserName = model.Email,
                    Address = model.Address
                };
                var result = await usermanager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.RoleId))
                    {
                        var role = await roleManager.FindByIdAsync(model.RoleId);
                        var addRoleResult = await usermanager.AddToRoleAsync(user, role.Name);
                        if (addRoleResult.Succeeded)
                        {
                            return RedirectToAction("Index", "User");
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);

                        }
                    }

                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }
                }

            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await usermanager.FindByIdAsync(id);

            if (user != null)
            {
                var model = new EditUserViewModel()
                {
                  
                    Address = user.Address,
                    Email = user.Email,
                    UserId = user.Id
                };
                var rolesName = await usermanager.GetRolesAsync(user);
                if (rolesName != null && rolesName.Any())
                {
                    var role = await roleManager.FindByNameAsync(rolesName.FirstOrDefault());
                    model.RoleId = role.Id;
                }
                ViewBag.Roles = roleManager.Roles;
                return View(model);
            }
            ViewBag.Roles = roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await usermanager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                   
                    user.Address = model.Address;
                    user.UserName = model.Email;
                    user.Email = model.Email;
                    user.Id = model.UserId;
                    var result = await usermanager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var rolesname = await usermanager.GetRolesAsync(user);
                        var delRole = await usermanager.RemoveFromRolesAsync(user, rolesname);
                        if (!string.IsNullOrEmpty(model.RoleId))
                        {
                            var role = await roleManager.FindByIdAsync(model.RoleId);
                            var addRoleResult = await usermanager.AddToRoleAsync(user, role.Name);
                            if (addRoleResult.Succeeded)
                            {
                                return RedirectToAction("Index", "User");

                            }
                            foreach (var error in addRoleResult.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }

                        }
                        return RedirectToAction("Index", "User");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return RedirectToAction("Index", "User");
                }

            }

            return View();
        }
        public async Task<IActionResult> Delete(string id)
        {
            var user = await usermanager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await usermanager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
    }
}