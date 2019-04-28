using MobileSuitcase.BackEnd.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.BackEndTests
{
    public class WorkerRepositoryTest
    {

        [Fact]
        public void ListWorkersTest()
        {
            WorkerRepository WorkerRepositorio = new WorkerRepository();

            var (ResponseCode, ResponseText, Resulting) = WorkerRepositorio.GetWorkers();
            Assert.Equal(ResponseCode, OK);
            Assert.True(ResponseCode == OK);
            Assert.Empty(ResponseText);
            Assert.Equal(ResponseText, string.Empty);
            Assert.Contains(ResponseText, string.Empty);
            Assert.NotNull(Resulting);
            Assert.True(Resulting.Count == 10);
            Assert.False(Resulting.Count < 10);
        }
    }
}
