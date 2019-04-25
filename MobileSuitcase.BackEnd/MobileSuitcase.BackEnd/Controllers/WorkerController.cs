using Microsoft.AspNetCore.Mvc;

namespace MobileSuitcase.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class WorkerController : ApplicationController
    {
        [HttpGet("[action]")]
        public IActionResult GetWorkers()
        {
            var (ResponseCode, ResponseText, Resulting) = UnitOfWork.Workers.GetWorkers();
            return CreateResponse(ResponseCode, ResponseText, Resulting);
        }
    }
}
