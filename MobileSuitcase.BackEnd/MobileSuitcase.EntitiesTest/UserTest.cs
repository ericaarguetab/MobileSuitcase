using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileSuitcase.Entities.Models;

namespace MobileSuitcase.EntitiesTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserEntity()
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

            Assert.Equals(usuario.UserName, UserName);
            Assert.Equals(usuario.Email, Email);
            Assert.Equals(usuario.Password, Password);
            Assert.Equals(usuario.FirstName, FirstName);
            Assert.Equals(usuario.LastName, LastName);

        }
    }
}
