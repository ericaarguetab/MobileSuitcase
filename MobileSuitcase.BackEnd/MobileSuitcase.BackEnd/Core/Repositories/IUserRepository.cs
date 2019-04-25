using MobileSuitcase.Entities.Models;
using MobileSuitcase.Entities.ViewModels;
using System.Net;
using System.Threading.Tasks;

namespace MobileSuitcase.BackEnd.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<(HttpStatusCode ResponseCode, string ResponseText, User UserLogged)> LoginAsync(LoginViewModel UserToLogin);
    }
}
