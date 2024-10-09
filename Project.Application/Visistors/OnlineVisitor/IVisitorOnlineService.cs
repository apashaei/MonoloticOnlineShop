using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Visistors.OnlineVisitor
{
    public interface IVisitorOnlineService
    {
        void ConnectUser(string ClientId);
        void DisconnectUser(string ClientId);
        int GetCount();
    }
}
