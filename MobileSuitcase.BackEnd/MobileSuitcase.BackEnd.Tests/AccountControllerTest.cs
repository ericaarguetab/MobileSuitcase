using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileSuitcase.BackEnd.Controllers;
using MobileSuitcase.Entities.ViewModels;

namespace MobileSuitcase.BackEnd.Tests
{
    [TestClass]
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


        [TestMethod]
        public void LoginTest()
        {
            var response = AccountEntity.Login(Usuario);
            Assert.IsNotNull(response);

        }
    }
}
