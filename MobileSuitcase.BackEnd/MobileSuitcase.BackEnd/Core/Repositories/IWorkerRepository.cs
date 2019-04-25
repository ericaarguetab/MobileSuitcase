using MobileSuitcase.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net;


namespace MobileSuitcase.BackEnd.Core.Repositories
{
    public interface IWorkerRepository : IRepository<Worker>
    {
        (HttpStatusCode ResponseCode, string ResponseText, List<Worker>) GetWorkers();
    }
}
