using Microsoft.AspNetCore.Mvc;
using MobileSuitcase.Entities.ViewModels;

namespace MobileSuitcase.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ApplicationController
    {
        [HttpPost("[action]")]
        public IActionResult Login([FromBody] LoginViewModel UserToLogin)
        {
            var (ResponseCode, ResponseText, UserLogged) = UnitOfWork.Users.LoginAsync(UserToLogin);
            return CreateResponse(ResponseCode, ResponseText, UserLogged);
        }
    }
}
