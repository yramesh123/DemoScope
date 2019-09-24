using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoScope.Filters
{
    public class CustomLogAttribute : ActionFilterAttribute
    {
        public CustomLogAttribute()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Trace.WriteLine(string.Format("Action Method {0} executed at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }
    }
}
