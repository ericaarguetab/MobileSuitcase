using MobileSuitcase.FrontEnd.Controllers;
using Xunit;
using MobileSuitcase.Entities.Models;
using MobileSuitcase.Entities.ViewModels;

namespace MobileSuitcase.FrontEndTests.Controllers
{
    public class AccountControllerTest
    {
        AccountController Usuario;
        LoginViewModel Inicio;

        public AccountControllerTest()
        {
            Usuario = new AccountController();
            Inicio = new LoginViewModel()
            {
                UserName = "erica@mobilesuitcase.com",
                Password = "Abc123."
            };
        }

        [Fact]
        public void LoginAsyncTest()
        {
            string returnUrl = string.Empty;
            var response = Usuario.Login(Inicio, returnUrl);
            Assert.NotNull(response);
        }

    }
}
