using BurgerMVCProject.Domain.Context;
using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.ContentModel;

namespace BurgerMVCProject.UI.Controllers.Identity
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly AppDbContext appDbContext;

        public AccountController(SignInManager<AppUser> _signInManager, UserManager<AppUser> _userManager, AppDbContext _appDbContext)
        {
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.appDbContext = _appDbContext;
        }

        public ActionResult Register()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View();
            }
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserVm userVm)
        {
            if (userVm.Password != userVm.RepeatPassword)
            {
                ModelState.AddModelError(nameof(userVm.Password), "Sign Up Failed : Paswords does not match.");
            }

            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userVm.Email);
                //email unique mi ?
                if (user != null)
                {
                    // E-posta adresi zaten kayıtlı ise hata mesajı verecek.
                    ModelState.AddModelError("EmailAddress", "Bu e-posta adresi zaten kayıtlı.");
                    return View();
                }
                AppUser appUser = new AppUser
                {
                    UserName = userVm.UserName,
                    FirstName = userVm.FirstName,
                    LastName = userVm.LastName,
                    Email = userVm.Email,

                };
                IdentityResult result = await userManager.CreateAsync(appUser, userVm.Password);

                if (result.Succeeded)
                {
                    string roleName = "User";

                    result = await userManager.AddToRoleAsync(appUser, roleName);

                    Order order = new();
                    order.AppUserId = userManager.Users.SingleOrDefault(x=>x.UserName == userVm.UserName).Id;

                    appDbContext.Orders.Add(order);
                    appDbContext.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("Create User", $"{item.Code} - {item.Description}");
                    }
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View();
            }
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserVm loginVm)
        {

            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginVm.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user.UserName, loginVm.Password, false, false);

                    if (result.Succeeded)
                    {
                        var roles = await userManager.GetRolesAsync(user);
                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Reports", new { area = "Admin" });
                        }
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                    else
                    {
                        ModelState.AddModelError("LoginError", "Invalid login attempt");

                    }
                }
                else
                {
                    ModelState.AddModelError("LoginError", "Invalid login attempt");

                }
            }
            return View(loginVm);
        }
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                IdentityResult result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Logout");
                }
                else
                {
                    Errors(result);

                }
            }
            else
            {
                ModelState.AddModelError("User", "User Not Found");
            }

            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError item in result.Errors)
            {
                ModelState.AddModelError("UpdateUser", $"{item.Code} - {item.Description}");
            }
        }
    }
}
