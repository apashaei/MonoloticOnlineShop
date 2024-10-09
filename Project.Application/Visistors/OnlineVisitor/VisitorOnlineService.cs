using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Visitors.visitor;

namespace Project.Application.Visistors.OnlineVisitor
{
    public class VisitorOnlineService : IVisitorOnlineService
    {
        private readonly IMongoDataBaseContext<OnlineVisitors> _mongoDataBaseContext;
        private readonly IMongoCollection<OnlineVisitors> _onlineVisitors;

        public VisitorOnlineService(IMongoDataBaseContext<OnlineVisitors> mongoDataBaseContext )
        {
            _mongoDataBaseContext = mongoDataBaseContext;
            _onlineVisitors = _mongoDataBaseContext.GetCollection();
        }
        public void ConnectUser(string ClientId)
        {
            var exist = _onlineVisitors.AsQueryable().FirstOrDefault(p => p.ClientId == ClientId);
            if (exist == null)
            {
                _onlineVisitors.InsertOne(new OnlineVisitors
                {
                    ClientId = ClientId,
                    Time = DateTime.Now,
                });
            }
            
        }

        public void DisconnectUser(string ClientId)
        {
            _onlineVisitors.FindOneAndDelete(p=>p.ClientId == ClientId);
        }

        public int GetCount()
        {
            return _onlineVisitors.AsQueryable().Count();
        }
    }
}
