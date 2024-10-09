using Microsoft.AspNetCore.Mvc.Filters;
using Project.Application.Visistors.SaveVisitorInfo;
using UAParser;

namespace Project.EndPoint.Utilities.Filters
{
    public class SavaVisitorFilter : IActionFilter
    {

        private readonly ISaveVisitorInfoService _saveVisitorInfoService;
        public SavaVisitorFilter(ISaveVisitorInfoService saveVisitorInfoService)
        {
            _saveVisitorInfoService = saveVisitorInfoService;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var Request = context.HttpContext.Request;
            string ip = context.HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            string actionName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ActionName;

            string controllerName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ControllerName;
            var userAgent = context.HttpContext.Request.Headers["User-Agent"];
            var uaParser = Parser.GetDefault();
            ClientInfo clientInfo =  uaParser.Parse(userAgent);
            //link that client try to insert by that.
            var referer = context.HttpContext.Request.Headers["Referer"].ToString();
            var currentUrl = context.HttpContext.Request.Path;
            var visitorId = context.HttpContext.Request.Cookies["VisitorId"];
           

            _saveVisitorInfoService.Excute(new VisitorDto
            {
                Browser = new VisitorVersionDto
                {
                    Family = clientInfo.UA.Family,
                    Version = $"{clientInfo.UA.Major}.{clientInfo.UA.Minor}.{clientInfo.UA.Patch}"
                },
                CurrentLink = currentUrl,
                Device = new DeviceDto
                {
                    Brand = clientInfo.Device.Brand,
                    Family = clientInfo.Device.Family,
                    IsSpider = clientInfo.Device.IsSpider,
                    Model = clientInfo.Device.Model,
                },
                IP = ip,
                Method = Request.Method,
                OperationSystem = new VisitorVersionDto
                {
                    Family = clientInfo.OS.Family,
                    Version = $"{clientInfo.UA.Major}.{clientInfo.UA.Minor}.{clientInfo.UA.Patch}"
                },
                PhysicalPath = $"{controllerName}/{actionName}",
                Protocol = Request.Protocol,
                ReferrerLink = referer,
                VisitorId = visitorId
            });
        }
    }
}
