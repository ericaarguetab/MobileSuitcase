using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using MobileSuitcase.Entities.Models;

namespace MobileSuitcase.FrontEnd.Controllers
{
    public class WorkerController : ApplicationController
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> Index()
        {
            var (ResponseCode, ResponseText, Result) = await _helper.CallGetApi<List<Worker>>("Worker/GetWorkers");
            return View(Result);
        }

    }
}