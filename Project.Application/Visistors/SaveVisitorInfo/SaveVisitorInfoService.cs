using MongoDB.Driver;
using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Visitors.visitor;

namespace Project.Application.Visistors.SaveVisitorInfo
{
    public class SaveVisitorInfoService : ISaveVisitorInfoService
    {
        private readonly IMongoDataBaseContext<Visitor> _mongoDataBaseContext;
        private IMongoCollection<Visitor> _collection;

        public SaveVisitorInfoService(IMongoDataBaseContext<Visitor> mongoDataBase)
        {
            _mongoDataBaseContext = mongoDataBase;
            _collection = _mongoDataBaseContext.GetCollection();
        }
        public void Excute(VisitorDto visitorDto)
        {
            _collection.InsertOne(new Visitor()
            {
                Browser = new VisitorVersion
                {
                    Family = visitorDto.Browser.Family,
                    Version = visitorDto.Browser.Version
                },
                CurrentLink = visitorDto.CurrentLink,
                
                IP = visitorDto.IP,
                Device = new Device
                {
                    Brand = visitorDto.Device.Brand,
                    Family = visitorDto.Device.Family,
                    IsSpider = visitorDto.Device.IsSpider,
                    Model = visitorDto.Device.Model
                },
                Method = visitorDto.Method,
                PhysicalPath = visitorDto.PhysicalPath,
                Protocol = visitorDto.Protocol,
                ReferrerLink = visitorDto.ReferrerLink,
                OperationSystem = new VisitorVersion
                {
                    Family = visitorDto.OperationSystem.Family,
                    Version = visitorDto.OperationSystem.Version
                },
                VisitorId = visitorDto.VisitorId,
                Time = DateTime.Now,
                

            });
        }
    }
}
