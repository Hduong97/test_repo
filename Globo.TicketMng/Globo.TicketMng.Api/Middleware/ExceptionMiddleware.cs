using Globo.TicketMng.Application.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace Globo.TicketMng.Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }
        private Task HandleException(HttpContext ctx, Exception ex)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
            ctx.Response.ContentType = "application/json";
            var result = string.Empty;
            switch (ex)
            {
                case BadRequestException:
                    result = JsonConvert.SerializeObject("");
                    break;
                case NotFoundException:
                    httpStatusCode = HttpStatusCode.NotFound;
                    break;
                default:
                    break;
            }
            ctx.Response.StatusCode = (int)httpStatusCode;
            return ctx.Response.WriteAsync(result);
        }
    }
}
