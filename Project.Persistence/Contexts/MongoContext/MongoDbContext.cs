using MongoDB.Driver;
using Project.Application.Interfaces.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence.Contexts.MongoContext
{
    public class MongoDbContext<T> : IMongoDataBaseContext<T>
    {
        private IMongoDatabase _db;
        private readonly IMongoCollection<T> _collection;

        public MongoDbContext()
        {
            var client = new MongoClient();
            _db = client.GetDatabase("VisitorDb");
            _collection = _db.GetCollection<T>(typeof(T).Name);
        }

        public IMongoCollection<T> GetCollection()
        {
            return _collection;
        }
    }
}
