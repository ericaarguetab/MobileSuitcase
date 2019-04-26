﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            Assert.AreEqual(usuario.UserName, UserName);
            Assert.AreEqual(usuario.Email, Email);
            Assert.AreEqual(usuario.Password, Password);
            Assert.AreEqual(usuario.FirstName, FirstName);
            Assert.AreEqual(usuario.LastName, LastName);

        }
    }
}
