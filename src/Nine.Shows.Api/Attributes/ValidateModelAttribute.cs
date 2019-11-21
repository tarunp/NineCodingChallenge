using Nine.Shows.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Nine.Shows.Shared;

namespace Nine.Shows.Api.Attributes
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorResponse error = new ErrorResponse() { Error = WellKnownConstants.ErrorString + WellKnownConstants.JsonParsingErrorString };
                context.Result = new BadRequestObjectResult(error);
                context.HttpContext.Response.ContentType = WellKnownConstants.JsonContentType;
            }
        }
    }
}
