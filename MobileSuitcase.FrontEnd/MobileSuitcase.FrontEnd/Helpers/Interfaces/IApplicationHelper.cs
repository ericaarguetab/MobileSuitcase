using System.Net;
using System.Threading.Tasks;

namespace MobileSuitcase.FrontEnd.Helpers.Interfaces
{
    public interface IApplicationHelper
    {
        Task<(HttpStatusCode ResponseCode, string ResponseText, T ResultingObject)> CallGetApi<T>(string RequestUrl);

        Task<(HttpStatusCode ResponseCode, string ResponseText, T ResultingObject)> CallPostApi<T>(string RequestUrl, object obj);

        Task<(HttpStatusCode ResponseCode, string ResponseText)> CallPostApi(string RequestUrl, object obj);

        Task<(HttpStatusCode ResponseCode, string ResponseText)> CallPutApi(string RequestUrl, object obj);
    }
}
