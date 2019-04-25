using MobileSuitcase.Entities.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MobileSuitcase.FrontEnd.Helpers
{
    public class MobileSuitcaseUser
    {
        private static string SessionKey = "__MobileSuitcaseWebUser__";

        public static User Session
        {
            get
            {
                User sessionUser = null;
                string session = CustomHttpContext.Current.Session.GetString(SessionKey);

                if (session != null)
                    sessionUser = JsonConvert.DeserializeObject<User>(session);

                return sessionUser;
            }
            set
            {
                CustomHttpContext.Current.Session.SetString(SessionKey, JsonConvert.SerializeObject(value));
            }
        }
    }
}
