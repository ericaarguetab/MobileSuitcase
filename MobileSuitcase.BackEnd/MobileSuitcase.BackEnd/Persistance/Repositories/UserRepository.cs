namespace MobileSuitcase.BackEnd.Persistance.Repositories
{
    using System.Net;
    using MobileSuitcase.BackEnd.Core.Repositories;
    using MobileSuitcase.Entities.Models;
    using MobileSuitcase.Entities.ViewModels;
    using static System.Net.HttpStatusCode;

    public class UserRepository : Repository<User>, IUserRepository 
    {

        public (HttpStatusCode ResponseCode, string ResponseText, User UserLogged) LoginAsync(LoginViewModel UserToLogin)
        {
            UserToLogin.UserName = UserToLogin.UserName.Trim();
            UserToLogin.Password = UserToLogin.Password.Trim();

            if(string.IsNullOrEmpty(UserToLogin.UserName) || string.IsNullOrEmpty(UserToLogin.Password))
            {
                return (NotFound, "Parámetros incompletos",null);
            }
            else if (UserToLogin.UserName.Equals("admin@mobilesuitcase.com") && UserToLogin.Password.Equals("Admin1524!"))
            {
                User Found = new User()
                {
                    FirstName = "Administrador",
                    LastName = "MobileSuitcase",
                    Email = "admin@mobilesuitcase.com",
                    UserName = "admin@mobilesuitcase.com"
                };

                return (OK, string.Empty, Found);
            }
            else
            {
                return (NotFound, "Usuario o contraseña incorrectos", null);
            }

        }

    }
}
