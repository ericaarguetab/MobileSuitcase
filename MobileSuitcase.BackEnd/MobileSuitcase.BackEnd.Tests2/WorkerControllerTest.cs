using MobileSuitcase.BackEnd.Controllers;
using MobileSuitcase.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace MobileSuitcase.BackEnd.Tests2
{
    public class WorkerControllerTest
    {
        [Fact]
        public void GetWorkersTest()
        {
            WorkerController WorkerEntity = new WorkerController();

            var response = WorkerEntity.GetWorkers();
            Assert.NotNull(response);

        }
    }
}
