using MobileSuitcase.Entities.Models;
using System;
using Xunit;

namespace MobileSuitcase.EntitiesTest2
{
    public class UserTest
    {
        [Fact]
        public void UserEntityTest()
        {
            string UserName = "admin@mobilesuitcase.com";
            string Email = "admin@mobilesuitcase.com";
            string Password = "Admin1524!";
            string FirstName = "Administrador";
            string LastName = "MobileSuitcase";

            var usuario = new User()
            {
                UserName = UserName,
                Email = Email,
                Password = Password,
                FirstName = FirstName,
                LastName = LastName
            };

            Assert.Equal(usuario.UserName, UserName);
            Assert.Equal(usuario.Email, Email);
            Assert.Equal(usuario.Password, Password);
            Assert.Equal(usuario.FirstName, FirstName);
            Assert.Equal(usuario.LastName, LastName);

        }
    }
}
