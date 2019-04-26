using MobileSuitcase.BackEnd.Controllers;
using MobileSuitcase.Entities.ViewModels;
using System;
using System.Net.Http;
using Xunit;

namespace MobileSuitcase.BackEnd.Tests2
{
    public class AccountControllerTest
    {
        [Fact]
        public void LoginTest()
        {
            AccountController AccountEntity;
            HttpClient Client;
            LoginViewModel Usuario;

            AccountEntity = new AccountController();
                Client = new HttpClient();

                Usuario = new LoginViewModel()
                {
                    UserName = "erica@mobilesuitcase.com",
                    Password = "Abc123."
                };

            var response = AccountEntity.Login(Usuario);
            Assert.NotNull(response);


        }
    }
}
