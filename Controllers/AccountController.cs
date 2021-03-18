using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopIP.Models;
using WebShopIP.Models.EmailModel;
using WebShopIP.Models.LoginViewModel;
using WebShopIP.Models.RegisterViewModel;

namespace WebShopIP.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
    
        [HttpGet]
        //[AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
   
        [HttpPost]
       
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    userName: model.Email,
                    password: model.Password,
                    isPersistent: model.RemenberMe,
                    lockoutOnFailure: false
                    );
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    return RedirectToAction("Index", "CustomerHome");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login Attemp");// co gang dang nhap khong hop le
                    if (!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                }

            }
            return View(model);
        }
   
        [HttpGet]
    
        public IActionResult Register()
        {
            return View();
        }


        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            var user = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName

            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var link = Url.Action("Confirmmail", "Account", new { userId = user.Id, code }, Request.Scheme, Request.Host.ToString());
                EmailModel emailConfirm = new EmailModel()
                {
                    Email = "Smtphungtran09051996@gmail.com",
                    Password = "h170909051996",
                    EmailSubject = "Xac Nhan Mail",
                    EmailBody = $"<h3>Xác Nhận Tài Khoản Của Bạn Nhấn Submit</h3>",
                    EmailTo = user.Email,
                    EmailContent = $"<a href=\"{link}\">Xác Nhận Tài Khoản Của Bạn</a>"
                };
                EmailUtilities.EmailUtilities.SenMail(emailConfirm, isBodyHtml: true);
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
            }

            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "CustomerHome");
        }
      
        public async Task<IActionResult> Confirmmail(string userId, string code)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await userManager.ConfirmEmailAsync(user, code);
                if (result.Succeeded)
                {

                    await signInManager.SignInAsync(user: user, isPersistent: false);
                    return View();
                }
            }
            return NotFound();
        }
    }
}
