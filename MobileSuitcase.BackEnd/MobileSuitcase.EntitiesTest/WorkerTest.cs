﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileSuitcase.Entities.Models;

namespace MobileSuitcase.EntitiesTest
{
    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        public void WorkerEntity()
        {
            string FirstName = "Miguel";
            string LastName = "Espinoza";
            string ImagePath = "https://thispersondoesnotexist.com/image";
            string Position = "Coordinator";
            int Age = 25;

            var colaborador = new Worker()
            {
                FirstName = FirstName,
                LastName = LastName,
                ImagePath = ImagePath,
                Position = Position,
                Age = Age
            };

            Assert.AreEqual(colaborador.FirstName, FirstName);
            Assert.AreEqual(colaborador.LastName, LastName);
            Assert.AreEqual(colaborador.ImagePath, ImagePath);
            Assert.AreEqual(colaborador.Position, Position);
            Assert.AreEqual(colaborador.Age, Age);
        }
    }
}
