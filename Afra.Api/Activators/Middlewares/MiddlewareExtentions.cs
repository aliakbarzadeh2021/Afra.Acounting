using Microsoft.AspNetCore.Builder;
using Afra.Api.Activators.Middlewares;

namespace Afra.Api.Activators.Middlewares
{
    public static class MiddlewareExtentions
    {
        
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}