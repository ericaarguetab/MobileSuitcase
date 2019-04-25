using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MobileSuitcase.FrontEnd.Helpers
{
    public class CustomHttpContext
    {
        private static IHttpContextAccessor _contextAccessor;

        public static HttpContext Current => _contextAccessor.HttpContext;

        internal static void Configure(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
    }

    public static class StaticHttpContextExtensions
    {
        public static void AddCustomHttpContextAccessor(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static IApplicationBuilder UseStaticHttpContext(this IApplicationBuilder app)
        {
            var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
            CustomHttpContext.Configure(httpContextAccessor);
            return app;
        }
    }
}
