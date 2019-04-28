﻿using System;
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

        public WorkerControllerTest()
        {
            Colaborador = new WorkerController();
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
