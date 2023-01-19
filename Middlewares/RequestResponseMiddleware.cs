namespace Middlewares
{
    public class RequestResponseMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<RequestResponseMiddleware> logger;
        public RequestResponseMiddleware(RequestDelegate next, ILogger<RequestResponseMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }   

        public async Task Invoke(HttpContext httpContext)
        {
            //Request 
            logger.LogInformation($"Query Keys : {String.Join(',', httpContext.Request.Query.Keys)}");

            logger.LogInformation($"Query Keys : {httpContext.Request.QueryString}");


            await next.Invoke(httpContext); //Response burada oluşuyor.

            //response burada alıyoruz

        }
    }
}
