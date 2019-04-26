using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MobileSuitcase.Entities.Models;
using MobileSuitcase.Entities.ViewModels;
using MobileSuitcase.FrontEnd.Controllers;

namespace MobileSuitcase.FrontEndTests.Controllers
{
    public class WorkerControllerTest
    {
        WorkerController Colaborador;
        LoginViewModel Inicio;

        public WorkerControllerTest()
        {
            Colaborador = new WorkerController();
            Inicio = new LoginViewModel()
            {
                UserName = "erica@mobilesuitcase.com",
                Password = "Abc123."
            };
        }

        [Fact]
        public void IndexTest()
        {
            string returnUrl = string.Empty;
            var response = Colaborador.Index();
            Assert.NotNull(response);
        }
    }
}
