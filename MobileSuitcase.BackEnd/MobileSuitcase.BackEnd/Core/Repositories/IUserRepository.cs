using MobileSuitcase.Entities.Models;
using MobileSuitcase.Entities.ViewModels;
using System.Net;

namespace MobileSuitcase.BackEnd.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        (HttpStatusCode ResponseCode, string ResponseText, User UserLogged) LoginAsync(LoginViewModel UserToLogin);
    }
}
