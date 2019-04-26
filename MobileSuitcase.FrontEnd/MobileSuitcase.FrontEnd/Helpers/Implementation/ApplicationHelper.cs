using MobileSuitcase.FrontEnd.Helpers.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.HttpStatusCode;

namespace MobileSuitcase.FrontEnd.Helpers.Implementation
{
    public class ApplicationHelper : IApplicationHelper
    {
        public static string UrlWebApi { get; set; } = "https://localhost:44314/api";
        private HttpClient client = new HttpClient();

        public async Task<(HttpStatusCode ResponseCode, string ResponseText, T ResultingObject)> CallGetApi<T>(string RequestUrl)
        {
            try
            {
                using (HttpResponseMessage result = await client.GetAsync(string.Format("{0}/{1}", UrlWebApi, RequestUrl)))
                {
                    if (result.StatusCode == OK)
                    {
                        string content = await result.Content.ReadAsStringAsync();
                        return (result.StatusCode, "", JsonConvert.DeserializeObject<T>(content));
                    }

                    return (result.StatusCode, await result.Content.ReadAsStringAsync(), Activator.CreateInstance<T>());
                }
            }
            catch (Exception ex)
            {
                return (InternalServerError, ex.Message, Activator.CreateInstance<T>());
            }
        }

        public async Task<(HttpStatusCode ResponseCode, string ResponseText, T ResultingObject)> CallPostApi<T>(string RequestUrl, object obj)
        {
            try
            {
                using (HttpResponseMessage result = await client.PostAsJsonAsync(string.Format("{0}/{1}", UrlWebApi, RequestUrl), obj))
                {
                    if (result.StatusCode == OK)
                    {
                        string content = await result.Content.ReadAsStringAsync();
                        return (result.StatusCode, "", JsonConvert.DeserializeObject<T>(content));
                    }

                    return (result.StatusCode, result.StatusCode == InternalServerError ? "Ha ocurrido un error inesperado." : await result.Content.ReadAsStringAsync(), Activator.CreateInstance<T>());
                }
            }
            catch (Exception ex)
            {
                return (InternalServerError, ex.Message, Activator.CreateInstance<T>());
            }
        }

        public async Task<(HttpStatusCode ResponseCode, string ResponseText)> CallPostApi(string RequestUrl, object obj)
        {
            try
            {
                using (HttpResponseMessage result = await client.PostAsJsonAsync(string.Format("{0}/{1}", UrlWebApi, RequestUrl), obj))
                {
                    return (result.StatusCode, result.StatusCode == InternalServerError ? "Ha ocurrido un error inesperado." : await result.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (InternalServerError, ex.Message);
            }
        }

        public async Task<(HttpStatusCode ResponseCode, string ResponseText)> CallPutApi(string RequestUrl, object obj)
        {
            try
            {
                using (HttpResponseMessage result = await client.PutAsJsonAsync(string.Format("{0}/{1}", UrlWebApi, RequestUrl), obj))
                {
                    return (result.StatusCode, result.StatusCode == InternalServerError ? "Ha ocurrido un error inesperado." : await result.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (InternalServerError, ex.Message);
            }
        }
    }
}
