using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileSuitcase.Entities.Models;
using MobileSuitcase.Entities.ViewModels;
using MobileSuitcase.FrontEnd.Helpers;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.FrontEnd.Controllers
{
    [Route("[controller]")]
    public class AccountController : ApplicationController
    {
        [HttpGet("[action]")]
        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Worker");
            }

            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel UserModel, string ReturnUrl = "")
        {
            if (!ModelState.IsValid) return View(UserModel);

            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", UserModel);
            if (ResponseCode == OK)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, Result.UserName),
                    new Claim(ClaimTypes.Email, Result.Email),
                    new Claim(ClaimTypes.Name, Result.FirstName),
                    new Claim(ClaimTypes.Surname, Result.LastName),
                };

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                MobileSuitcaseUser.Session = Result;

                return Redirect(Url.Action("Index", "Worker"));
            }
            else
            {
                ModelState.AddModelError("Intento de inicio de sesión no válido.", ResponseText);
                return View(UserModel);
            }
        }

        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
            return RedirectToAction("Login");
        }
    }
}