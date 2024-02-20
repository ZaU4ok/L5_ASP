using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;

namespace LR5_ASP
{
    public class ErrorLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorLoggingMiddleware> _logger;

        public ErrorLoggingMiddleware(RequestDelegate next, ILogger<ErrorLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                LogExceptionToFile(ex);

                throw;
            }
        }

        private void LogExceptionToFile(Exception exception)
        {
            string logFilePath = "error.log";

            using (StreamWriter writer = new StreamWriter(logFilePath, append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Timestamp: {DateTime.Now}");
                sb.AppendLine($"Message: {exception.Message}");
                sb.AppendLine($"StackTrace: {exception.StackTrace}");
                sb.AppendLine(new string('-', 50));

                writer.WriteLine(sb.ToString());
            }
        }
    }
}
