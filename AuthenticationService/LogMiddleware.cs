using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.WriteEvent($"Обращение к серверу с {httpContext.Request.Host}") ;
            await _next(httpContext);
        }
    }
}
