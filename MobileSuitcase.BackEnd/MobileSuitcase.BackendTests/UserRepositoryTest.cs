using MobileSuitcase.BackEnd.Persistance.Repositories;
using MobileSuitcase.Entities.ViewModels;
using Xunit;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.BackEndTests
{
    public class UserRepositoryTest
    {
        [Fact]
        public void LoginAsyncTest()
        {
            UserRepository UserRepositorio = new UserRepository();
            LoginViewModel Usuario = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1524!"
            };

            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(Usuario);
            Assert.True(ResponseCode == OK);
            Assert.Empty(ResponseText);
            Assert.NotNull(Resulting);
        }

        [Fact]
        public void LoginIncorrectTest()
        {
            UserRepository UserRepositorio = new UserRepository();
            LoginViewModel UsuarioIncorrecto = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1234!"
            };

            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(UsuarioIncorrecto);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Usuario o contraseña incorrectos", ResponseText);
            Assert.Null(Resulting);
        }

        [Fact]
        public void LoginEmptyTest()
        {
            UserRepository UserRepositorio = new UserRepository();
            LoginViewModel UsuarioVacio = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = ""
            };

            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(UsuarioVacio);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Parámetros incompletos", ResponseText);
            Assert.Null(Resulting);
        }
    }
}
