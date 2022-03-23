namespace WebApplication1.Infrastructure.MiddleWare
{
    public class GlobalExceptionHandler 
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public GlobalExceptionHandler(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString(), ex);
                context.Response.Redirect($"/Error?message={ex.Message }");
            }
        }
    }
}
