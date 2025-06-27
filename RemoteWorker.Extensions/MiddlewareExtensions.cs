using Microsoft.AspNetCore.Builder;
using RemoteWorker.Middleware;

namespace RemoteWorker.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseApiExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiExceptionMiddleware>();
        }
    }
}
