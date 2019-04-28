using MobileSuitcase.Entities.Models;
using MobileSuitcase.FrontEnd.Helpers.Implementation;
using MobileSuitcase.FrontEnd.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;
using static System.Net.HttpStatusCode;
using System.Threading.Tasks;
using MobileSuitcase.Entities.ViewModels;

namespace MobileSuitcase.FrontEndTests.Helpers
{
    public class ApplicationHelperTest
    {
        IApplicationHelper _helper;
        HttpClient client;
        LoginViewModel UserModel;
        LoginViewModel UserIncorrect;
        LoginViewModel PassIncorrect;
        LoginViewModel EmptyUser;
        LoginViewModel EmptyPass;

        public ApplicationHelperTest()
        {
            _helper = new ApplicationHelper();
            client = new HttpClient();
            
            //Usuario y contraseña correctos
            UserModel = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1524!"
            };
            //Cuenta con contraseña incorrecta
            UserIncorrect = new LoginViewModel()
            {
                UserName = "admin@mobilesuitcase.com",
                Password = "Admin1324!"
            };
            //Cuenta con usuario incorrecto
            PassIncorrect = new LoginViewModel()
            {
                UserName = "admin1@mobilesuitcase.com",
                Password = "Admin1524!"
            };

            //Cuenta con usuario vacio
            EmptyUser = new LoginViewModel()
            {
                UserName = "",
                Password = "Admin1524!"
            };
            //Cuenta con contraseña vacia
            EmptyPass = new LoginViewModel()
            {
                UserName = "admin@gmail.com",
                Password = ""
            };
        }


        [Fact]
        public async Task GetTestAsync()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallGetApi<List<Worker>>("Worker/GetWorkers");
            Assert.Equal(ResponseCode, OK);
            Assert.True(ResponseCode == OK);
            Assert.Equal(ResponseText, string.Empty);
            Assert.Contains(ResponseText, string.Empty);
            Assert.Empty(ResponseText);
            Assert.NotNull(Result);
            Assert.True(Result.Count == 10);
        }

        [Fact]
        public async Task PostTest()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", UserModel);
            Assert.Equal(ResponseCode, OK);
            Assert.True(ResponseCode == OK);
            Assert.Equal(ResponseText, string.Empty);
            Assert.Contains(ResponseText, string.Empty);
            Assert.Empty(ResponseText);
            Assert.NotNull(Result);
        }

        [Fact]
        public async Task PostUserTest()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", UserIncorrect);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Contains("Usuario o contraseña incorrectos", ResponseText);
            Assert.NotNull(Result);
        }

        [Fact]
        public async Task PostPassTest()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", PassIncorrect);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Contains("Usuario o contraseña incorrectos", ResponseText);
            Assert.NotNull(Result);
        }


        [Fact]
        public async Task PostEmptyUserTest()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", EmptyUser);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Contains("Parámetros incompletos", ResponseText);
            Assert.NotNull(Result);
            
        }

        [Fact]
        public async Task PostEmptyPsswdTest()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallPostApi<User>("Account/Login", EmptyPass);
            Assert.NotEqual(ResponseCode, OK);
            Assert.False(ResponseCode == OK);
            Assert.NotEqual(ResponseText, string.Empty);
            Assert.Contains("Parámetros incompletos", ResponseText);
            Assert.NotNull(Result);
        }


    }
}
