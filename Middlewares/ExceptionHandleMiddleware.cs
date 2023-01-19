namespace Middlewares
{
    public class ExceptionHandleMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandleMiddleware> logger;
        public ExceptionHandleMiddleware(RequestDelegate Next, ILogger<ExceptionHandleMiddleware> Logger)
        {
            next = Next;
            logger = Logger;
        }

        public async Task Invoke(HttpContext httpcontext)
        {
            try
            {
                await next.Invoke(httpcontext);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
        }
    }
}
