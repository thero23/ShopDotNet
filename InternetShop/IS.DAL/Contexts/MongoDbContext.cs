using IS.DAL.Contexts.Configurations;
using IS.DAL.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace IS.DAL.Contexts
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<Settings> settings)
        {
            var connection = new MongoUrlBuilder(settings.Value.ConnectionString);
            var client = new MongoClient(settings.Value.ConnectionString);
            if(client is not null)
            {
                _database = client.GetDatabase(connection.DatabaseName);
            }
                
        }
        public IMongoCollection<ProductEntity> Products { get
            {
                return _database.GetCollection<ProductEntity>("Products");
            }
        }
    }
}
