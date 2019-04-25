using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Security.Principal;
using System;
using Microsoft.AspNetCore.StaticFiles;
using System.IO;
using MobileSuitcase.FrontEnd.Helpers;
using MobileSuitcase.FrontEnd.Helpers.Interfaces;
using MobileSuitcase.FrontEnd.Helpers.Implementation;

namespace MobileSuitcase.FrontEnd.Controllers
{
    [Authorize]
    public class ApplicationController : Controller
    {
        protected IApplicationHelper _helper = new ApplicationHelper();

        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            string ActionName = ctx.ActionDescriptor.RouteValues["action"];
            string ControllerName = ctx.ActionDescriptor.RouteValues["controller"];

            if (User.Identity.IsAuthenticated && MobileSuitcaseUser.Session == null)
            {
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                ctx.HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
                ctx.Result = new RedirectToActionResult("Login", "Account", null);
            }

            base.OnActionExecuting(ctx);
        }
    }
}