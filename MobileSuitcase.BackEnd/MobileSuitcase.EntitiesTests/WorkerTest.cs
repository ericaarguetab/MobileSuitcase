using MobileSuitcase.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MobileSuitcase.EntitiesTests
{
    public class WorkerTest
    {
        [Fact]
        public void WorkerEntityTest()
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

            Assert.Equal(colaborador.FirstName, FirstName);
            Assert.Equal(colaborador.LastName, LastName);
            Assert.Equal(colaborador.ImagePath, ImagePath);
            Assert.Equal(colaborador.Position, Position);
            Assert.Equal(colaborador.Age, Age);

        }
    }
}
