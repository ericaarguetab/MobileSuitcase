using MobileSuitcase.BackEnd.Controllers;
using Xunit;

namespace MobileSuitcase.BackEndTests
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
