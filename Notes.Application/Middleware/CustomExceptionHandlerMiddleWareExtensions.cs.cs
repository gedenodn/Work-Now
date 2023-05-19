using Microsoft.AspNetCore.Builder;

namespace Notes.Application.Middleware
{
    public static class CustomExceptionHandlerMiddleWareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this 
            IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
