using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using static System.Net.HttpStatusCode;
using MobileSuitcase.BackEnd.Persistance;

namespace MobileSuitcase.BackEnd.Controllers
{
    public class ApplicationController : Controller
    {
        protected UnitOfWork UnitOfWork;

        public ApplicationController()
        {
            this.UnitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Generic response to a request
        /// </summary>
        /// <param name="StatusCode"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public ObjectResult CreateResponse(HttpStatusCode StatusCode, object obj) => new ObjectResult(obj) { StatusCode = (int)StatusCode };

        public ObjectResult CreateResponse(HttpStatusCode StatusCode, string ResponseText, object obj) => new ObjectResult((StatusCode == OK ? obj : ResponseText)) { StatusCode = (int)StatusCode };

        public override void OnActionExecuted(ActionExecutedContext ctx)
        {
            UnitOfWork.Dispose();
        }
    }
}