using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace ProjectConsultants.Filters
{
    /// <summary>
    /// Custom Exception Filter for Api
    /// </summary>
    /// <seealso cref="System.Web.Http.Filters.ExceptionFilterAttribute" />
    public class CustomApiExceptionFilter : ExceptionFilterAttribute
    {

        /// <summary>
        /// Raises the exception event.
        /// </summary>
        /// <param name="actionExecutedContext">The context for the action.</param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)

        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;

            string message = string.Empty;

            var exceptionType = actionExecutedContext.Exception.GetType();

            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Access to the Web API is not authorized.";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(DivideByZeroException))
            {
                message = "Internal Server Error.";
                status = HttpStatusCode.InternalServerError;
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                message = "Internal Server Error.";
                status = HttpStatusCode.InternalServerError;
            }
            else
            {
                message = "Not found.";
                status = HttpStatusCode.NotFound;
            }

            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent(message, System.Text.Encoding.UTF8, "text/plain"),
                StatusCode = status

            };
            base.OnException(actionExecutedContext);

        }

    }
}