using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileSuitcase.BackEnd.Controllers;

namespace MobileSuitcase.BackEnd.Tests
{
    [TestClass]
    public class WorkerControllerTest
    {
        public WorkerController WorkerEntity;

        public WorkerControllerTest()
        {
            WorkerEntity = new WorkerController();
        }

        [TestMethod]
        public void GetWorkersTest()
        {
            var response = WorkerEntity.GetWorkers();
            Assert.IsNotNull(response);
        }
    }
}
