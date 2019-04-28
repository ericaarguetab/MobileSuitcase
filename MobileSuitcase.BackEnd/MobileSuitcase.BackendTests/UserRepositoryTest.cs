using MobileSuitcase.BackEnd.Persistance.Repositories;
using MobileSuitcase.Entities.ViewModels;
using Xunit;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.BackEndTests
{
    public class UserRepositoryTest
    {
        UserRepository UserRepositorio;
        LoginViewModel User;
        LoginViewModel UserIncorrect;
        LoginViewModel PassIncorrect;
        LoginViewModel UserEmpty;
        LoginViewModel PassEmpty;

        public UserRepositoryTest()
        {
            UserRepositorio = new UserRepository();
            User = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1524!"
            };

            UserIncorrect = new LoginViewModel()
            {
                UserName = "admin10@mobilesuitcase.com",
                Password = "Admin1524!"
            };

            PassIncorrect = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1234!"
            };

            UserEmpty = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = ""
            };

            PassEmpty = new LoginViewModel()
            {
                UserName = "",
                Password = "Admin1524!"
            };
        }

        [Fact]
        public void LoginAsyncTest()
        {      
            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(User);
            Assert.True(ResponseCode == OK);
            Assert.Equal(ResponseCode, OK);
            Assert.Empty(ResponseText);
            Assert.Equal(ResponseText, string.Empty);
            Assert.Contains(ResponseText, string.Empty);
            Assert.NotNull(Resulting);
        }

        [Fact]
        public void LoginIncorrectTest()
        {
            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(UserIncorrect);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Usuario o contraseña incorrectos", ResponseText);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Null(Resulting);
        }

        [Fact]
        public void LoginPassIncorrectTest()
        {
            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(PassIncorrect);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Usuario o contraseña incorrectos", ResponseText);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Null(Resulting);
        }

        [Fact]
        public void LoginUserEmptyTest()
        {
            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(UserEmpty);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Parámetros incompletos", ResponseText);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Null(Resulting);
        }

        [Fact]
        public void LoginPassEmptyTest()
        {
            var (ResponseCode, ResponseText, Resulting) = UserRepositorio.LoginAsync(PassEmpty);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.Contains("Parámetros incompletos", ResponseText);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Null(Resulting);
        }
    }
}
