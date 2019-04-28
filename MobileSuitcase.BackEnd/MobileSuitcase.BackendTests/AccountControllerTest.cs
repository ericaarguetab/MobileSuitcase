using MobileSuitcase.BackEnd.Controllers;
using MobileSuitcase.Entities.ViewModels;
using System;
using System.Net.Http;
using Xunit;

namespace MobileSuitcase.BackEndTests
{
    public class AccountControllerTest
    {
        AccountController AccountEntity;
        HttpClient Client;
        LoginViewModel Usuario;

        public AccountControllerTest()
        {
            AccountEntity = new AccountController();
            Client = new HttpClient();

            Usuario = new LoginViewModel()
            {
                UserName = "erica@mobilesuitcase.com",
                Password = "Abc123."
            };
        }
       
        [Fact]
        public void LoginTest()
        {
            var response = AccountEntity.Login(Usuario);
            Assert.NotNull(response);
        }
    }
}
