using Microsoft.AspNetCore.SignalR;
using Project.Application.Visistors.OnlineVisitor;
using Project.Domain.Visitors.visitor;
using System.Runtime.CompilerServices;

namespace Admin.EndPoint.Hubs
{
    public class OnLineVisitorHub : Hub
    {

        private readonly IVisitorOnlineService _visitorOnlineService;

        public OnLineVisitorHub(IVisitorOnlineService visitorOnlineService)
        {
            _visitorOnlineService = visitorOnlineService;
        }
        public override Task OnConnectedAsync()
        {
            var visitorId = Context.GetHttpContext().Request.Cookies["VisitorId"].ToString();
            _visitorOnlineService.ConnectUser(visitorId);
            var onlineUsers = _visitorOnlineService.GetCount();
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var visitorId = Context.GetHttpContext().Request.Cookies["VisitorId"].ToString();

            _visitorOnlineService.DisconnectUser(visitorId);
            var onlineUsers = _visitorOnlineService.GetCount();
            return base.OnDisconnectedAsync(exception);
        }
    }
}
