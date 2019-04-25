namespace MobileSuitcase.BackEnd.Persistance.Repositories
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using IFC.Web.BackEnd.Core;
    using IFC.Web.BackEnd.Core.Repositories;
    using IFC.Web.BackEnd.Utilities;
    using IFC.Web.Entities.Models;
    using IFC.Web.Entities.ViewModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using MobileSuitcase.BackEnd.Core.Repositories;
    using MobileSuitcase.Entities.Models;
    using MobileSuitcase.Entities.ViewModels;
    using static System.Net.HttpStatusCode;

    public class UserRepository : Repository<User>, IUserRepository 
    {

        public async Task<(HttpStatusCode ResponseCode, string ResponseText, User UserLogged)> LoginAsync(LoginViewModel UserToLogin)
        {

            if(UserToLogin.UserName != null && UserToLogin.Password != null)



            _Where = w => w.UserName == login.UserName || w.Email == login.UserName;
            User Found = (await WhereAsync("Role,UserCompanies")).FirstOrDefault();
            if (Found == null)
                return (NotFound, "El usuario ingresado no existe.", null);
            else
            {
                if (!Found.Enabled)
                {
                    return (NotFound, "El usuario ingresado está inhabilitado.", null);
                }

                var (ResponseCode, ResponseText, Decrypted) = cypher.DecryptData(Found.Password);
                if (ResponseCode == OK && Decrypted == login.Password)
                {
                    if (Found.UserCompanies.Count > 0)
                    {
                        await Context.Entry(Found).Collection(x => x.UserCompanies).Query().OfType<UserCompany>().Include(y => y.Company).LoadAsync();
                    }

                    Found.Password = null;
                    Found.PasswordResetToken = null;
                    return (OK, string.Empty, Found);
                }
                else
                {
                    return (NotFound, "Se ha ingresado una contraseña incorrecta.", null);
                }
            }
        }

    }
}
